using System;
using System.Windows.Forms;


namespace _7_Segment
{
    public partial class ArrayForm : Form
    {
        #region Fields
        private readonly bool[,] CharMap = new bool[16,8] 
        {
            { true, true, true, true, true, true, false, false },     // 0
            { false, true, true, false, false, false, false, false }, // 1
            { true, true, false, true, true, false, true, false },    // 2
            { true, true, true, true, false, false, true, false },    // 3
            { false, true, true, false, false, true, true, false },   // 4
            { true, false, true, true, false, true, true, false },    // 5
            { true, false, true, true, true, true, true, false },     // 6
            { true, true, true, false, false, false, false, false },  // 7
            { true, true, true, true, true, true, true, false },      // 8
            { true, true, true, true, false, true, true, false },     // 9
            { true, true, true, false, true, true, true, false },     // A
            { false, false, true, true, true, true, true, false },    // B
            { true, false, false, true, true, true, false, false },   // C
            { false, true, true, true, true, false, true, false },    // D
            { true, false, false, true, true, true, true, false },    // E
            { true, false, false, false, true, true, true, false }    // F
        };

        private string                   _CopyValue;
        private Func<Func<int,bool>,int> _ValueBuilder;
        #endregion

        #region Ctors
        public ArrayForm()
        {
            InitializeComponent();

            CharSetSelect.SelectedIndex     = 0;
            SystemValueSelect.SelectedIndex = 0;
        }
        #endregion

        #region Utils
        private void BuildArray()
        {
            if (_ValueBuilder != null)
            {
                int cs = CharSetSelect.SelectedIndex == 0 ? 10 : 16;
                int sv = 10;
                switch (SystemValueSelect.SelectedIndex)
                {
                    case 0: sv = 2; break;
                    case 1: sv = 8; break;
                    case 2: sv = 10; break;
                    case 3: sv = 16; break;
                }

                _CopyValue  = "const unsigned char digits[] = {";
                string text = _CopyValue + "\r\n";

                for (int i = 0; i < cs; i++)
                {
                    string value = Converter.ValueToString(_ValueBuilder(s => CharMap[i,s]), sv);

                    text       += '\t' + value;
                    _CopyValue += value;

                    text       += (i == (cs - 1) ? " " : ",") + " // '" + i.ToString("X") + "'\r\n";
                    _CopyValue +=  i == (cs - 1) ? "};" : ",";
                }

                ArrayValue.Text = text + "};";
                ArrayValue.SelectionLength = 0;
            }
        }
        #endregion

        #region Handlers
        private void CopyClick(object sender, EventArgs e)
        {
            if (ArrayValue.SelectionLength == 0)
            {
                Clipboard.SetText(_CopyValue);
            }
            else
            {
                ArrayValue.Copy();
            }
        }

        private void ButtonCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnChange(object sender, EventArgs e)
        {
            BuildArray();
        }
        #endregion

        #region Methods
        public void ShowDialog(Func<Func<int,bool>,int> ValueBuilder)
        {
            _ValueBuilder = ValueBuilder;
            BuildArray();
            base.ShowDialog();
        }
        #endregion
    }
}
