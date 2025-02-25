﻿
namespace WindowsFormsStrings
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search_source = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.search_index = new System.Windows.Forms.TextBox();
            this.search_substring = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.search_register = new System.Windows.Forms.CheckBox();
            this.search_method_best = new System.Windows.Forms.CheckBox();
            this.search_method_kmp = new System.Windows.Forms.CheckBox();
            this.search_method_naive = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.search_time_spent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search_position_result = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1267, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поиск подстроки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1261, 592);
            this.splitContainer1.SplitterDistance = 401;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(1261, 401);
            this.splitContainer2.SplitterDistance = 237;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.search_source);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1261, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходная строка";
            // 
            // search_source
            // 
            this.search_source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_source.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_source.Location = new System.Drawing.Point(3, 22);
            this.search_source.MaxLength = 1073741824;
            this.search_source.Multiline = true;
            this.search_source.Name = "search_source";
            this.search_source.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.search_source.Size = new System.Drawing.Size(1255, 212);
            this.search_source.TabIndex = 0;
            this.search_source.Text = resources.GetString("search_source.Text");
            this.search_source.TextChanged += new System.EventHandler(this.search_source_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1261, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подстрока";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.7251F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.2749F));
            this.tableLayoutPanel2.Controls.Add(this.search_index, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.search_substring, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.35593F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.64407F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1255, 135);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // search_index
            // 
            this.search_index.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_index.Location = new System.Drawing.Point(237, 112);
            this.search_index.Name = "search_index";
            this.search_index.Size = new System.Drawing.Size(1015, 26);
            this.search_index.TabIndex = 4;
            this.search_index.Text = "0";
            this.search_index.TextChanged += new System.EventHandler(this.search_index_TextChanged);
            // 
            // search_substring
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.search_substring, 2);
            this.search_substring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_substring.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_substring.Location = new System.Drawing.Point(3, 3);
            this.search_substring.Multiline = true;
            this.search_substring.Name = "search_substring";
            this.search_substring.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.search_substring.Size = new System.Drawing.Size(1249, 103);
            this.search_substring.TabIndex = 2;
            this.search_substring.Text = "Князь Андрей, в числе других безнадежных раненых, был сдан на попечение жителей.";
            this.search_substring.TextChanged += new System.EventHandler(this.search_substring_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Откуда вести поиск";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer3.Size = new System.Drawing.Size(1261, 187);
            this.splitContainer3.SplitterDistance = 280;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.search_register);
            this.groupBox3.Controls.Add(this.search_method_best);
            this.groupBox3.Controls.Add(this.search_method_kmp);
            this.groupBox3.Controls.Add(this.search_method_naive);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Метод поиска";
            // 
            // search_register
            // 
            this.search_register.AutoSize = true;
            this.search_register.Location = new System.Drawing.Point(9, 150);
            this.search_register.Name = "search_register";
            this.search_register.Size = new System.Drawing.Size(176, 24);
            this.search_register.TabIndex = 3;
            this.search_register.Text = "Учитывать регистр";
            this.search_register.UseVisualStyleBackColor = true;
            this.search_register.CheckedChanged += new System.EventHandler(this.search_register_CheckedChanged);
            // 
            // search_method_best
            // 
            this.search_method_best.AutoSize = true;
            this.search_method_best.Location = new System.Drawing.Point(9, 96);
            this.search_method_best.Name = "search_method_best";
            this.search_method_best.Size = new System.Drawing.Size(273, 44);
            this.search_method_best.TabIndex = 2;
            this.search_method_best.Text = "Метод Кнутта-Морриса-Пратта \r\n(Все вхождения)";
            this.search_method_best.UseVisualStyleBackColor = true;
            this.search_method_best.CheckedChanged += new System.EventHandler(this.search_method_best_CheckedChanged);
            // 
            // search_method_kmp
            // 
            this.search_method_kmp.AutoSize = true;
            this.search_method_kmp.Location = new System.Drawing.Point(9, 52);
            this.search_method_kmp.Name = "search_method_kmp";
            this.search_method_kmp.Size = new System.Drawing.Size(273, 44);
            this.search_method_kmp.TabIndex = 1;
            this.search_method_kmp.Text = "Метод Кнутта-Морриса-Пратта \r\n(Первое вхождение)";
            this.search_method_kmp.UseVisualStyleBackColor = true;
            this.search_method_kmp.CheckedChanged += new System.EventHandler(this.search_method_kmp_CheckedChanged);
            // 
            // search_method_naive
            // 
            this.search_method_naive.AutoSize = true;
            this.search_method_naive.Checked = true;
            this.search_method_naive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.search_method_naive.Location = new System.Drawing.Point(9, 24);
            this.search_method_naive.Name = "search_method_naive";
            this.search_method_naive.Size = new System.Drawing.Size(149, 24);
            this.search_method_naive.TabIndex = 0;
            this.search_method_naive.Text = "Наивный метод";
            this.search_method_naive.UseVisualStyleBackColor = true;
            this.search_method_naive.CheckedChanged += new System.EventHandler(this.search_method_naive_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.tableLayoutPanel1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(977, 187);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Результаты";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.64329F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.35671F));
            this.tableLayoutPanel1.Controls.Add(this.search_time_spent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.search_position_result, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 162);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // search_time_spent
            // 
            this.search_time_spent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_time_spent.Location = new System.Drawing.Point(213, 84);
            this.search_time_spent.Name = "search_time_spent";
            this.search_time_spent.ReadOnly = true;
            this.search_time_spent.Size = new System.Drawing.Size(755, 26);
            this.search_time_spent.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Время поиска";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Позиция подстроки";
            // 
            // search_position_result
            // 
            this.search_position_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_position_result.Location = new System.Drawing.Point(213, 3);
            this.search_position_result.Name = "search_position_result";
            this.search_position_result.ReadOnly = true;
            this.search_position_result.Size = new System.Drawing.Size(755, 26);
            this.search_position_result.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1275, 631);
            this.tabControl1.TabIndex = 0;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 631);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form";
            this.Text = "String operations";
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox search_source;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox search_time_spent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_position_result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox search_index;
        private System.Windows.Forms.TextBox search_substring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox search_method_best;
        private System.Windows.Forms.CheckBox search_method_kmp;
        private System.Windows.Forms.CheckBox search_method_naive;
        private System.Windows.Forms.CheckBox search_register;
    }
}

