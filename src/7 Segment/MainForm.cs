using System;
using System.Windows.Forms;


namespace _7_Segment
{
    public partial class MainForm : Form
    {
        #region Fields
        private ArrayForm _ArrayForm;
        #endregion

        #region Ctors
        public MainForm()
        {
            InitializeComponent();

            BindSegmentA.SelectedIndex  = 0;
            BindSegmentB.SelectedIndex  = 1;
            BindSegmentC.SelectedIndex  = 2;
            BindSegmentD.SelectedIndex  = 3;
            BindSegmentE.SelectedIndex  = 4;
            BindSegmentF.SelectedIndex  = 5;
            BindSegmentG.SelectedIndex  = 6;
            BindSegmentDp.SelectedIndex = 7;

            _ArrayForm       = new ArrayForm();
            _ArrayForm.Owner = this;
        }
        #endregion

        #region Utils
        private int BuildValue(Func<int,bool> SegmentsMapping)
        {
            bool common = CommonCathode.Checked;
            int  unused = 0;
            int  value  = 0;

            foreach (Control c in SegmentsBindingBox.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;

                    if (cb.SelectedIndex < 8)
                    {
                        unused |= 1 << cb.SelectedIndex;
                    }

                    if (!(SegmentsMapping((int)cb.Tag) ^ common))
                    {
                        value |= 1 << cb.SelectedIndex;
                    }
                }
            }

            if (FillUnusedBitsOne.Checked)
            {
                value = (value | (unused ^ 0xFF)) & 0xFF;
            }
            else
            {
                value = (value & unused) & 0xFF;
            }

            return value;
        }
        #endregion

        #region Handlers
        private void OnChange(object sender, EventArgs e)
        {
            int sv = 10;
            if (Bin.Checked)
            {
                sv = 2;
            }
            else if (Oct.Checked)
            {
                sv = 8;
            }
            else if (Hex.Checked)
            {
                sv = 16;
            }

            Value.Text = Converter.ValueToString(BuildValue(s => Indikator[(LedSegment)s]), sv);
        }

        private void ArrayClick(object sender, EventArgs e)
        {
            _ArrayForm.ShowDialog(BuildValue);
        }

        private void ValueCopyClick(object sender, EventArgs e)
        {
            Clipboard.SetText(Value.Text);
        }
        #endregion
    }

    public class Converter
    {
        public static string ValueToString(int value, int sv)
        {
            if (sv == 2)
            {
                return "0b" + Convert.ToString(value, 2).PadLeft(8, '0');
            }
            if (sv == 8)
            {
                return Convert.ToString(value, 8).PadLeft(4, '0');
            }
            if (sv == 16)
            {
                return "0x" + value.ToString("X2");
            }
            return value.ToString().PadLeft(3, ' ');
        }
    }
}