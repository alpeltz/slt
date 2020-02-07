using System.Drawing;

namespace SourceLiveTimer.View
{
    partial class BestPossibleTimeUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BestPossibleTimeTextLabel = new System.Windows.Forms.Label();
            this.BestPossibleTimeTimeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.BestPossibleTimeTextLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.BestPossibleTimeTimeLabel, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(152, 30);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // BestPossibleTimeTextLabel
            // 
            this.BestPossibleTimeTextLabel.AutoSize = true;
            this.BestPossibleTimeTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.BestPossibleTimeTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BestPossibleTimeTextLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestPossibleTimeTextLabel.ForeColor = System.Drawing.Color.Black;
            this.BestPossibleTimeTextLabel.Location = new System.Drawing.Point(3, 3);
            this.BestPossibleTimeTextLabel.Margin = new System.Windows.Forms.Padding(3);
            this.BestPossibleTimeTextLabel.Name = "BestPossibleTimeTextLabel";
            this.BestPossibleTimeTextLabel.Size = new System.Drawing.Size(104, 24);
            this.BestPossibleTimeTextLabel.TabIndex = 3;
            this.BestPossibleTimeTextLabel.Text = "Best Possible Time";
            this.BestPossibleTimeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BestPossibleTimeTimeLabel
            // 
            this.BestPossibleTimeTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BestPossibleTimeTimeLabel.AutoSize = true;
            this.BestPossibleTimeTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.BestPossibleTimeTimeLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestPossibleTimeTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.BestPossibleTimeTimeLabel.Location = new System.Drawing.Point(204, 4);
            this.BestPossibleTimeTimeLabel.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.BestPossibleTimeTimeLabel.Name = "BestPossibleTimeTimeLabel";
            this.BestPossibleTimeTimeLabel.Size = new System.Drawing.Size(12, 22);
            this.BestPossibleTimeTimeLabel.TabIndex = 3;
            this.BestPossibleTimeTimeLabel.Text = "-";
            this.BestPossibleTimeTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BestPossibleTimeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BestPossibleTimeUI";
            this.Size = new System.Drawing.Size(152, 30);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label BestPossibleTimeTextLabel;
        private System.Windows.Forms.Label BestPossibleTimeTimeLabel;
    }
}
