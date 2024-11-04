using System;
using System.Drawing;
using System.Windows.Forms;


namespace _7_Segment
{
    public enum LedSegment
    {
        A  = 0,
        B  = 1,
        C  = 2,
        D  = 3,
        E  = 4,
        F  = 5,
        G  = 6,
        DP = 7
    };

    public class SegmentIndikator : Control
    {
        #region Fields
        private bool[]   _Segments;
        private Bitmap[] _OnImages;
        private Bitmap[] _OffImages;
        private Point    _Offset;
        #endregion

        #region Ctors
        public SegmentIndikator()
        {
            this.Size = new Size(172, 260);
            _Offset   = new Point((Width - 132) / 2, (Height - 198) / 2);

            _Segments  = new bool[8] { false, false, false, false, false, false, false, false };
            _OffImages = Properties.Resources.OffImages;
            _OnImages  = Properties.Resources.OnImages;

            ContextMenuStrip = new ContextMenuStrip();
            ContextMenuStrip.Items.Add("Clear",     Properties.Resources.Clear,     MenuClearClick);
            ContextMenuStrip.Items.Add("Fill",      Properties.Resources.Fill,      MenuFillClick);
            ContextMenuStrip.Items.Add("Inversion", Properties.Resources.Inversion, MenuInversionClick);
            ContextMenuStrip.Items.Add("MirrorX",   Properties.Resources.MirrorX,   MenuMirrorXClick);
            ContextMenuStrip.Items.Add("MirrorY",   Properties.Resources.MirrorY,   MenuMirrorYClick);

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
        }
        #endregion

        #region Properties
        public bool this[LedSegment segment]
        {
            get
            {
                return _Segments[(int)segment];
            }

            set
            {
                _Segments[(int)segment] = value;

                Invalidate();

                SegmentsChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        #endregion

        #region Methods
        public void Clear()
        {
            for (int i = 0; i < 8; i++)
            {
                _Segments[i] = false;
            }

            Invalidate();

            SegmentsChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Fill()
        {
            for (int i = 0; i < 8; i++)
            {
                _Segments[i] = true;
            }

            Invalidate();

            SegmentsChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Inversion()
        {
            for (int i = 0; i < 8; i++)
            {
                _Segments[i] = !_Segments[i];
            }

            Invalidate();

            SegmentsChanged?.Invoke(this, EventArgs.Empty);
        }

        public void MirrorX()
        {
            bool temp;

            temp = _Segments[5];
            _Segments[5] = _Segments[1];
            _Segments[1] = temp;

            temp = _Segments[4];
            _Segments[4] = _Segments[2];
            _Segments[2] = temp;

            Invalidate();

            SegmentsChanged?.Invoke(this, EventArgs.Empty);
        }

        public void MirrorY()
        {
            bool temp;

            temp = _Segments[0];
            _Segments[0] = _Segments[3];
            _Segments[3] = temp;

            temp = _Segments[5];
            _Segments[5] = _Segments[4];
            _Segments[4] = temp;

            temp = _Segments[1];
            _Segments[1] = _Segments[2];
            _Segments[2] = temp;

            Invalidate();

            SegmentsChanged?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region Events
        public event EventHandler SegmentsChanged;
        #endregion

        #region Utils
        private int GetSegment(int x, int y)
        {
            Bitmap temp = new Bitmap(Width, Height);
            DrawToBitmap(temp, new Rectangle(0, 0, x+1, y+1));
            Color color = temp.GetPixel(x, y);

            if (color.B > 190)
            {
                return ((((color.R - 199) & 0x01) << 2) | (((color.G - 199) & 0x01) << 1) | (((color.B - 199) & 0x01) << 0));
            }
            if (color.B > 150)
            {
                return ((((color.R - 0) & 0x01) << 2) | (((color.G - 254) & 0x01) << 1) | (((color.B - 152) & 0x01) << 0));
            }

            return -1;
        }
        #endregion

        #region Handlers
        private void MenuClearClick(object sender, EventArgs e)
        {
            Clear();
        }

        private void MenuFillClick(object sender, EventArgs e)
        {
            Fill();
        }

        private void MenuInversionClick(object sender, EventArgs e)
        {
            Inversion();
        }

        private void MenuMirrorXClick(object sender, EventArgs e)
        {
            MirrorX();
        }

        private void MenuMirrorYClick(object sender, EventArgs e)
        {
            MirrorY();
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.FillRectangle(Brushes.Black, new Rectangle(0, 0, Width, Height));

            for (int i = 0; i < 8; i++)
            {
                e.Graphics.DrawImage(_Segments[i] ? _OnImages[i] : _OffImages[i], _Offset);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                int segment = GetSegment(e.X, e.Y);

                if (segment != -1)
                {
                    _Segments[segment] ^= true;

                    Invalidate();

                    SegmentsChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        #endregion
    }
}