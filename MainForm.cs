namespace WFA230110_3
{
    public partial class MainForm : Form
    {
        public MainControl MainControl { get; set; }
        public ColorControl ColorControl { get; set; }
        public ExitControl ExitControl { get; set; }

        public MainForm()
        {
            InitializeComponent();

            btnMain.Click += OnMainButtonClick;
            btnColor.Click += OnColorButtonClick;
            btnExit.Click += OnExitButtonClick;
        }
        private void SetCenter(UserControl control)
        {
            control.Location = new()
            {
                X = (pnlMain.Width - control.Width) / 2,
                Y = (pnlMain.Height - control.Height) / 2,
            };
        }

        private void OnMainButtonClick(object? sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            MainControl mainControl = new();
            SetCenter(mainControl);
            pnlMain.Controls.Add(mainControl);
        }

        private void OnColorButtonClick(object? sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ColorControl colorControl = new ColorControl(this);
            SetCenter(colorControl);
            pnlMain.Controls.Add(colorControl);
        }

        private void OnExitButtonClick(object? sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ExitControl exitControl = new();
            SetCenter(exitControl);
            pnlMain.Controls.Add(exitControl);
        }

    }
}