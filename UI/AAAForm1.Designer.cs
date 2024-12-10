namespace MyScanApp
{
    partial class AAAForm1
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
            ctrlocv1 = new AutoTF.UserCtrls.ctrlOCV();
            SuspendLayout();
            // 
            // ctrlocv1
            // 
            ctrlocv1.Location = new Point(239, 113);
            ctrlocv1.Name = "ctrlocv1";
            ctrlocv1.Size = new Size(281, 232);
            ctrlocv1.TabIndex = 0;
            // 
            // AAAForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ctrlocv1);
            Name = "AAAForm1";
            Text = "AAAForm1";
            ResumeLayout(false);
        }

        #endregion

        private AutoTF.UserCtrls.ctrlOCV ctrlocv1;
    }
}