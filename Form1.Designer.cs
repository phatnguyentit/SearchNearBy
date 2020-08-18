namespace SearchNearBy
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnMap = new System.Windows.Forms.Panel();
            this.pb = new System.Windows.Forms.PictureBox();
            this.gvPositions = new System.Windows.Forms.DataGridView();
            this.lbScale = new System.Windows.Forms.Label();
            this.sbSearchZone = new System.Windows.Forms.VScrollBar();
            this.lbFindZone = new System.Windows.Forms.Label();
            this.lbZoneValue = new System.Windows.Forms.Label();
            this.lbFindCount = new System.Windows.Forms.Label();
            this.lbFound = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.numRandom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMap
            // 
            this.pnMap.Controls.Add(this.pb);
            this.pnMap.Location = new System.Drawing.Point(364, 35);
            this.pnMap.Name = "pnMap";
            this.pnMap.Size = new System.Drawing.Size(600, 600);
            this.pnMap.TabIndex = 0;
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb.Location = new System.Drawing.Point(0, 0);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(600, 600);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // gvPositions
            // 
            this.gvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPositions.Location = new System.Drawing.Point(12, 35);
            this.gvPositions.Name = "gvPositions";
            this.gvPositions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPositions.Size = new System.Drawing.Size(323, 600);
            this.gvPositions.TabIndex = 3;
            // 
            // lbScale
            // 
            this.lbScale.AutoSize = true;
            this.lbScale.Location = new System.Drawing.Point(364, 12);
            this.lbScale.Name = "lbScale";
            this.lbScale.Size = new System.Drawing.Size(75, 13);
            this.lbScale.TabIndex = 4;
            this.lbScale.Text = "1 point = 5 Km";
            // 
            // sbFindZone
            // 
            this.sbSearchZone.Location = new System.Drawing.Point(982, 35);
            this.sbSearchZone.Name = "sbFindZone";
            this.sbSearchZone.Size = new System.Drawing.Size(31, 600);
            this.sbSearchZone.SmallChange = 2;
            this.sbSearchZone.TabIndex = 7;
            // 
            // lbFindZone
            // 
            this.lbFindZone.AutoSize = true;
            this.lbFindZone.Location = new System.Drawing.Point(474, 12);
            this.lbFindZone.Name = "lbFindZone";
            this.lbFindZone.Size = new System.Drawing.Size(56, 13);
            this.lbFindZone.TabIndex = 8;
            this.lbFindZone.Text = "Find zone:";
            // 
            // lbZoneValue
            // 
            this.lbZoneValue.AutoSize = true;
            this.lbZoneValue.Location = new System.Drawing.Point(533, 12);
            this.lbZoneValue.Name = "lbZoneValue";
            this.lbZoneValue.Size = new System.Drawing.Size(0, 13);
            this.lbZoneValue.TabIndex = 8;
            // 
            // lbFindCount
            // 
            this.lbFindCount.AutoSize = true;
            this.lbFindCount.Location = new System.Drawing.Point(622, 13);
            this.lbFindCount.Name = "lbFindCount";
            this.lbFindCount.Size = new System.Drawing.Size(40, 13);
            this.lbFindCount.TabIndex = 8;
            this.lbFindCount.Text = "Found:";
            // 
            // lbFound
            // 
            this.lbFound.AutoSize = true;
            this.lbFound.Location = new System.Drawing.Point(683, 13);
            this.lbFound.Name = "lbFound";
            this.lbFound.Size = new System.Drawing.Size(13, 13);
            this.lbFound.TabIndex = 8;
            this.lbFound.Text = "0";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(12, 6);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 9;
            this.btnRandom.Text = "Random position";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // numRandom
            // 
            this.numRandom.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numRandom.Location = new System.Drawing.Point(106, 8);
            this.numRandom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRandom.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numRandom.Name = "numRandom";
            this.numRandom.Size = new System.Drawing.Size(120, 20);
            this.numRandom.TabIndex = 10;
            this.numRandom.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Km";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 654);
            this.Controls.Add(this.numRandom);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lbZoneValue);
            this.Controls.Add(this.lbFound);
            this.Controls.Add(this.lbFindCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFindZone);
            this.Controls.Add(this.sbSearchZone);
            this.Controls.Add(this.lbScale);
            this.Controls.Add(this.gvPositions);
            this.Controls.Add(this.pnMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView gvPositions;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Panel pnMap;

        #endregion

        private System.Windows.Forms.Label lbScale;
        private System.Windows.Forms.VScrollBar sbSearchZone;
        private System.Windows.Forms.Label lbFindZone;
        private System.Windows.Forms.Label lbZoneValue;
        private System.Windows.Forms.Label lbFindCount;
        private System.Windows.Forms.Label lbFound;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.NumericUpDown numRandom;
        private System.Windows.Forms.Label label1;
    }
}

