using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SourceLiveTimer.Speedrun;
using SourceLiveTimer.Util;

namespace SourceLiveTimer.View
{
    partial class BestPossibleTimeUI : UserControl, RunViewComponent
    {
        private Run run;

        private const int SUM_OF_BEST_HEIGHT = 20;
        private Font SUM_OF_BEST_TEXT_FONT = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Font SUM_OF_BEST_TIME_FONT = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Color SUM_OF_BEST_TEXT_COLOR = System.Drawing.Color.White;
        private TimeFormatter TIME_FORMATTER = new FancyTimeFormatter("-");

        public BestPossibleTimeUI()
        {
            InitializeComponent();
            this.BestPossibleTimeTextLabel.Font = SUM_OF_BEST_TEXT_FONT;
            this.BestPossibleTimeTimeLabel.Font = SUM_OF_BEST_TIME_FONT;
            this.BestPossibleTimeTextLabel.ForeColor = SUM_OF_BEST_TEXT_COLOR;
            this.BestPossibleTimeTimeLabel.ForeColor = SUM_OF_BEST_TEXT_COLOR;
            this.tableLayoutPanel.RowStyles[0].Height = SUM_OF_BEST_HEIGHT;
        }

        public void LoadRun(Run run)
        {
           // BestPossibleTimeTimeLabel.Text = "Hello";
            this.run = run;
            UpdateComponent();
        }

        public void UpdateComponent()
        {
            int? BestPossibleTime = run.GetBestPossibleTime();
            BestPossibleTimeTimeLabel.Text = TIME_FORMATTER.FormatTicks(BestPossibleTime, run.Category.TicksPerSecond);
        }

        public void UnloadRun()
        {
            run = null;
            BestPossibleTimeTimeLabel.Text = TIME_FORMATTER.NullTime;
        }        

    }
}
