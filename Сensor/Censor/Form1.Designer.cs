namespace Censor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInsert = new Label();
            textInput = new TextBox();
            btnControl = new Button();
            lblResult = new Label();
            textOutput = new TextBox();
            SuspendLayout();
            // 
            // lblInsert
            // 
            lblInsert.AutoSize = true;
            lblInsert.Location = new Point(149, 34);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(60, 15);
            lblInsert.TabIndex = 0;
            lblInsert.Text = "Insert Text";
            // 
            // textInput
            // 
            textInput.Location = new Point(21, 52);
            textInput.Multiline = true;
            textInput.Name = "textInput";
            textInput.Size = new Size(339, 238);
            textInput.TabIndex = 1;
            // 
            // btnControl
            // 
            btnControl.Location = new Point(119, 328);
            btnControl.Name = "btnControl";
            btnControl.Size = new Size(131, 27);
            btnControl.TabIndex = 2;
            btnControl.Text = "CONTROL TEXT";
            btnControl.UseVisualStyleBackColor = true;
            btnControl.Click += btnControl_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(561, 34);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(86, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result Window";
            // 
            // textOutput
            // 
            textOutput.Location = new Point(416, 52);
            textOutput.Multiline = true;
            textOutput.Name = "textOutput";
            textOutput.Size = new Size(372, 386);
            textOutput.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textOutput);
            Controls.Add(lblResult);
            Controls.Add(btnControl);
            Controls.Add(textInput);
            Controls.Add(lblInsert);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInsert;
        private TextBox textInput;
        private Button btnControl;
        private Label lblResult;
        private TextBox textOutput;
    }
}