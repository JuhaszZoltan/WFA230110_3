using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA230110_3
{
    public partial class ColorControl : UserControl
    {
        Random random = new();
        public MainForm MainForm { get; }

        public ColorControl(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();

            tbRed.ValueChanged += OnTrackBarValueChanged;
            tbGreen.ValueChanged += OnTrackBarValueChanged;
            tbBlue.ValueChanged += OnTrackBarValueChanged;

            tbRed.Value = random.Next(256);
            tbGreen.Value = random.Next(256);
            tbBlue.Value = random.Next(256);

            btnApply.Click += OnButtonApplyClick;
        }

        private void OnButtonApplyClick(object? sender, EventArgs e)
        {
            MainForm.pnlMain.BackColor = pbColorPreview.BackColor;
        }

        private void OnTrackBarValueChanged(object? sender, EventArgs e)
        {
            pbColorPreview.BackColor = Color.FromArgb(
                red: tbRed.Value,
                green: tbGreen.Value,
                blue: tbBlue.Value);
        }
    }
}
