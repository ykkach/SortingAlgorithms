namespace SortingAlgorithms
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
            this.Randomize = new System.Windows.Forms.Button();
            this.numOfElements = new System.Windows.Forms.TextBox();
            this.sort = new System.Windows.Forms.Button();
            this.sortingtime = new System.Windows.Forms.GroupBox();
            this.countingTime = new System.Windows.Forms.Label();
            this.quickTime = new System.Windows.Forms.Label();
            this.mergeTime = new System.Windows.Forms.Label();
            this.shellTime = new System.Windows.Forms.Label();
            this.selectionTime = new System.Windows.Forms.Label();
            this.bubbleTime = new System.Windows.Forms.Label();
            this.outputResults = new System.Windows.Forms.Button();
            this.sortingtime.SuspendLayout();
            this.SuspendLayout();
            // 
            // Randomize
            // 
            this.Randomize.Location = new System.Drawing.Point(46, 102);
            this.Randomize.Name = "Randomize";
            this.Randomize.Size = new System.Drawing.Size(198, 64);
            this.Randomize.TabIndex = 0;
            this.Randomize.Text = "Generate";
            this.Randomize.UseVisualStyleBackColor = true;
            this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
            // 
            // numOfElements
            // 
            this.numOfElements.Location = new System.Drawing.Point(46, 48);
            this.numOfElements.Name = "numOfElements";
            this.numOfElements.Size = new System.Drawing.Size(198, 26);
            this.numOfElements.TabIndex = 1;
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(46, 172);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(198, 64);
            this.sort.TabIndex = 2;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // sortingtime
            // 
            this.sortingtime.Controls.Add(this.countingTime);
            this.sortingtime.Controls.Add(this.quickTime);
            this.sortingtime.Controls.Add(this.mergeTime);
            this.sortingtime.Controls.Add(this.shellTime);
            this.sortingtime.Controls.Add(this.selectionTime);
            this.sortingtime.Controls.Add(this.bubbleTime);
            this.sortingtime.Location = new System.Drawing.Point(296, 48);
            this.sortingtime.Name = "sortingtime";
            this.sortingtime.Size = new System.Drawing.Size(230, 561);
            this.sortingtime.TabIndex = 4;
            this.sortingtime.TabStop = false;
            this.sortingtime.Text = "Sorting time";
            // 
            // countingTime
            // 
            this.countingTime.AutoSize = true;
            this.countingTime.Location = new System.Drawing.Point(25, 426);
            this.countingTime.Name = "countingTime";
            this.countingTime.Size = new System.Drawing.Size(111, 20);
            this.countingTime.TabIndex = 5;
            this.countingTime.Text = "Counting Sort:";
            // 
            // quickTime
            // 
            this.quickTime.AutoSize = true;
            this.quickTime.Location = new System.Drawing.Point(25, 344);
            this.quickTime.Name = "quickTime";
            this.quickTime.Size = new System.Drawing.Size(87, 20);
            this.quickTime.TabIndex = 4;
            this.quickTime.Text = "Quick Sort:";
            // 
            // mergeTime
            // 
            this.mergeTime.AutoSize = true;
            this.mergeTime.Location = new System.Drawing.Point(25, 262);
            this.mergeTime.Name = "mergeTime";
            this.mergeTime.Size = new System.Drawing.Size(92, 20);
            this.mergeTime.TabIndex = 3;
            this.mergeTime.Text = "Merge Sort:";
            // 
            // shellTime
            // 
            this.shellTime.AutoSize = true;
            this.shellTime.Location = new System.Drawing.Point(25, 188);
            this.shellTime.Name = "shellTime";
            this.shellTime.Size = new System.Drawing.Size(82, 20);
            this.shellTime.TabIndex = 2;
            this.shellTime.Text = "Shell Sort:";
            // 
            // selectionTime
            // 
            this.selectionTime.AutoSize = true;
            this.selectionTime.Location = new System.Drawing.Point(25, 117);
            this.selectionTime.Name = "selectionTime";
            this.selectionTime.Size = new System.Drawing.Size(113, 20);
            this.selectionTime.TabIndex = 1;
            this.selectionTime.Text = "Selection Sort:";
            // 
            // bubbleTime
            // 
            this.bubbleTime.AutoSize = true;
            this.bubbleTime.Location = new System.Drawing.Point(25, 41);
            this.bubbleTime.Name = "bubbleTime";
            this.bubbleTime.Size = new System.Drawing.Size(97, 20);
            this.bubbleTime.TabIndex = 0;
            this.bubbleTime.Text = "Bubble Sort:";
            // 
            // outputResults
            // 
            this.outputResults.Location = new System.Drawing.Point(46, 286);
            this.outputResults.Name = "outputResults";
            this.outputResults.Size = new System.Drawing.Size(198, 68);
            this.outputResults.TabIndex = 5;
            this.outputResults.Text = "Get sorting results";
            this.outputResults.UseVisualStyleBackColor = true;
            this.outputResults.Click += new System.EventHandler(this.outputResults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 651);
            this.Controls.Add(this.outputResults);
            this.Controls.Add(this.sortingtime);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.numOfElements);
            this.Controls.Add(this.Randomize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sortingtime.ResumeLayout(false);
            this.sortingtime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Randomize;
        private System.Windows.Forms.TextBox numOfElements;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.GroupBox sortingtime;
        private System.Windows.Forms.Label countingTime;
        private System.Windows.Forms.Label quickTime;
        private System.Windows.Forms.Label mergeTime;
        private System.Windows.Forms.Label shellTime;
        private System.Windows.Forms.Label selectionTime;
        private System.Windows.Forms.Label bubbleTime;
        private System.Windows.Forms.Button outputResults;
    }
}

