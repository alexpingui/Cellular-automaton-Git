namespace Cellular_Automaton_Noob_Edition
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createMapBtn = new System.Windows.Forms.Button();
            this.runStopBtn = new System.Windows.Forms.Button();
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.columnsTextBox = new System.Windows.Forms.TextBox();
            this.AutomatonScreen = new Cellular_Automaton_Noob_Edition.Screen();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.AutomatonScreen);
            this.MainSplitContainer.Size = new System.Drawing.Size(1198, 694);
            this.MainSplitContainer.SplitterDistance = 224;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.createMapBtn, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.runStopBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.rowsTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.columnsTextBox, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 694);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество строк";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество столбцов";
            // 
            // createMapBtn
            // 
            this.createMapBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createMapBtn.Location = new System.Drawing.Point(3, 647);
            this.createMapBtn.Name = "createMapBtn";
            this.createMapBtn.Size = new System.Drawing.Size(218, 44);
            this.createMapBtn.TabIndex = 4;
            this.createMapBtn.Text = "Создать";
            this.createMapBtn.UseVisualStyleBackColor = true;
            this.createMapBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.createBtn_MouseClick);
            // 
            // runStopBtn
            // 
            this.runStopBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runStopBtn.Location = new System.Drawing.Point(3, 549);
            this.runStopBtn.Name = "runStopBtn";
            this.runStopBtn.Size = new System.Drawing.Size(218, 92);
            this.runStopBtn.TabIndex = 5;
            this.runStopBtn.Text = "Запустить / Остановить";
            this.runStopBtn.UseVisualStyleBackColor = true;
            this.runStopBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.runStopBtn_MouseClick);
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowsTextBox.Location = new System.Drawing.Point(3, 33);
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(218, 22);
            this.rowsTextBox.TabIndex = 3;
            this.rowsTextBox.Text = "50";
            // 
            // columnsTextBox
            // 
            this.columnsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnsTextBox.Location = new System.Drawing.Point(3, 101);
            this.columnsTextBox.Name = "columnsTextBox";
            this.columnsTextBox.Size = new System.Drawing.Size(218, 22);
            this.columnsTextBox.TabIndex = 1;
            this.columnsTextBox.Text = "50";
            // 
            // AutomatonScreen
            // 
            this.AutomatonScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutomatonScreen.Location = new System.Drawing.Point(0, 0);
            this.AutomatonScreen.Name = "AutomatonScreen";
            this.AutomatonScreen.Size = new System.Drawing.Size(970, 694);
            this.AutomatonScreen.TabIndex = 0;
            this.AutomatonScreen.Text = "screen1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 694);
            this.Controls.Add(this.MainSplitContainer);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cellular Automaton";
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox columnsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rowsTextBox;
        private System.Windows.Forms.Button createMapBtn;
        private Screen AutomatonScreen;
        private System.Windows.Forms.Button runStopBtn;
    }
}

