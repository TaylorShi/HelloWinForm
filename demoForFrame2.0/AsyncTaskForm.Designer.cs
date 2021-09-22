
namespace demoForFrame2._0
{
    partial class AsyncTaskForm
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
            this.lab_Progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_Progress
            // 
            this.lab_Progress.AutoSize = true;
            this.lab_Progress.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Progress.Location = new System.Drawing.Point(353, 188);
            this.lab_Progress.Name = "lab_Progress";
            this.lab_Progress.Size = new System.Drawing.Size(76, 21);
            this.lab_Progress.TabIndex = 0;
            this.lab_Progress.Text = "label1";
            // 
            // AsyncTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_Progress);
            this.Name = "AsyncTaskForm";
            this.Text = "AsyncTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Progress;
    }
}