namespace WinForms_MapControl_VecLayer_DataLoadedEvent {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.bLoadData = new System.Windows.Forms.Button();
            this.lLayerState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bLoadData
            // 
            this.bLoadData.Location = new System.Drawing.Point(12, 12);
            this.bLoadData.Name = "bLoadData";
            this.bLoadData.Size = new System.Drawing.Size(75, 23);
            this.bLoadData.TabIndex = 1;
            this.bLoadData.Text = "Load Data";
            this.bLoadData.UseVisualStyleBackColor = true;
            this.bLoadData.Click += new System.EventHandler(this.bLoadData_Click);
            // 
            // lLayerState
            // 
            this.lLayerState.AutoSize = true;
            this.lLayerState.Location = new System.Drawing.Point(12, 38);
            this.lLayerState.Name = "lLayerState";
            this.lLayerState.Size = new System.Drawing.Size(0, 13);
            this.lLayerState.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 443);
            this.Controls.Add(this.lLayerState);
            this.Controls.Add(this.bLoadData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLoadData;
        private System.Windows.Forms.Label lLayerState;
    }
}

