﻿using ClassLibraryStrings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
namespace WindowsFormsStrings
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void search_index_TextChanged(object sender, System.EventArgs e)
        {
            Search_Change();
        }

        private void Search_Enforce_Validity_Index()
        {
            int temp;
            if (int.TryParse(search_index.Text, out temp))
            {
                search_index.Text = Math.Max(0, Math.Min(temp, search_source.TextLength - search_substring.TextLength)).ToString();
            }
            else
            {
                for (int i = search_index.TextLength - 1; i >= 0; i--)
                {
                    if (search_index.Text[i] < '0' || search_index.Text[i] > '9')
                    {
                        search_index.Text = search_index.Text.Remove(i, 1);
                    }
                }
            }
            if (search_index.Text == "")
            {
                search_index.Text = "0";
            }
        }

        private void search_substring_TextChanged(object sender, System.EventArgs e)
        {
            Search_Change();
        }

        private void search_source_TextChanged(object sender, System.EventArgs e)
        {
            Search_Change();
        }

        private void search_method_naive_CheckedChanged(object sender, System.EventArgs e)
        {
            if (search_method_naive.Checked)
            {
                search_method_kmp.Checked = false;
                search_method_best.Checked = false;
            }
            else if (!search_method_naive.Checked && !search_method_kmp.Checked && !search_method_best.Checked)
            {
                search_method_naive.Checked = true;
            }
            Search_Change();
        }

        private void search_method_kmp_CheckedChanged(object sender, System.EventArgs e)
        {
            if (search_method_kmp.Checked)
            {
                search_method_naive.Checked = false;
                search_method_best.Checked = false;
            }
            else if (!search_method_naive.Checked && !search_method_kmp.Checked && !search_method_best.Checked)
            {
                search_method_kmp.Checked = true;
            }
            Search_Change();
        }

        private void search_method_best_CheckedChanged(object sender, System.EventArgs e)
        {
            if (search_method_best.Checked)
            {
                search_method_kmp.Checked = false;
                search_method_naive.Checked = false;
            }
            else if (!search_method_naive.Checked && !search_method_kmp.Checked && !search_method_best.Checked)
            {
                search_method_best.Checked = true;
            }
            Search_Change();
        }
        List<(Thread thread, CancellationTokenSource cts)> threads = new List<(Thread thread, CancellationTokenSource cts)>();
        void Search_Change()
        {
            Search_Enforce_Validity_Index();
            foreach (var item in threads)
            {
                item.cts.Cancel();
            }
            threads.Clear();
            CancellationTokenSource cts = new CancellationTokenSource();
            if (search_method_naive.Checked)
            {
                search_position_result.Multiline = false;
                search_position_result.ScrollBars = System.Windows.Forms.ScrollBars.None;
                var th1 = new Thread(Search_Calculate_Naive);
                threads.Add((th1, cts));
                th1.Start(cts.Token);
            }
            if (search_method_kmp.Checked)
            {
                search_position_result.Multiline = false;
                search_position_result.ScrollBars = System.Windows.Forms.ScrollBars.None;
                Thread th1 = new Thread(Search_Calculate_Kmp);
                threads.Add((th1, cts));
                th1.Start(cts.Token);
            }
            if (search_method_best.Checked)
            {
                search_position_result.Multiline = true;
                search_position_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                Thread th1 = new Thread(Search_Calculate_Best);
                threads.Add((th1, cts));
                th1.Start(cts.Token);
            }

        }
        void Search_Calculate_Naive(object ct)
        {
            if (search_substring.Text == "")
            {
                Invoke(new Action(() => search_position_result.Text = "Подстрока должна содержать по крайней мере один символ."));
                Invoke(new Action(() => search_time_spent.Text = "Подстрока должна содержать по крайней мере один символ."));
                return;
            }
            CancellationToken Ca = (CancellationToken)ct;
            Stopwatch sw = new Stopwatch();
            Invoke(new Action(() => search_position_result.Text = "Происходит Вычисление ..."));
            Invoke(new Action(() => search_time_spent.Text = "Происходит Вычисление ..."));
            int pos;
            if (search_register.Checked)
            {
                string temp_source = search_source.Text, temp_substring = search_substring.Text;
                sw.Start();
                pos = Strings.IndexOfAny_Primitive(temp_source, temp_substring, int.Parse(search_index.Text));
            }
            else
            {
                string temp_source = search_source.Text.ToUpper(), temp_substring = search_substring.Text.ToUpper();
                sw.Start();
                pos = Strings.IndexOfAny_Primitive(temp_source, temp_substring, int.Parse(search_index.Text));
            }
            sw.Stop();
            if (Ca.IsCancellationRequested)
            {
                return;
            }
            if (pos == -1)
            {
                Invoke(new Action(() => search_position_result.Text = "Не найдено"));
                Invoke(new Action(() => search_time_spent.Text = $"{sw.ElapsedMilliseconds} мс."));
            }
            else
            {
                Invoke(new Action(() => search_position_result.Text = $"{pos}"));
                Invoke(new Action(() => search_time_spent.Text = $"{sw.ElapsedMilliseconds} мс."));
            }
        }
        void Search_Calculate_Kmp(object ct)
        {
            if (search_substring.Text == "")
            {
                Invoke(new Action(() => search_position_result.Text = "Подстрока должна содержать по крайней мере один символ."));
                Invoke(new Action(() => search_time_spent.Text = "Подстрока должна содержать по крайней мере один символ."));
                return;
            }
            CancellationToken Ca = (CancellationToken)ct;
            Stopwatch sw = new Stopwatch();
            Invoke(new Action(() => search_position_result.Text = "Происходит Вычисление ..."));
            Invoke(new Action(() => search_time_spent.Text = "Происходит Вычисление ..."));
            int pos;
            if (search_register.Checked)
            {
                string temp_source = search_source.Text, temp_substring = search_substring.Text;
                sw.Start();
                pos = Strings.IndexOf_KMP(temp_source, temp_substring, int.Parse(search_index.Text));
            }
            else
            {
                string temp_source = search_source.Text.ToUpper(), temp_substring = search_substring.Text.ToUpper();
                sw.Start();
                pos = Strings.IndexOf_KMP(temp_source, temp_substring, int.Parse(search_index.Text));
            }
            sw.Stop();
            if (Ca.IsCancellationRequested)
            {
                return;
            }
            if (pos == -1)
            {
                Invoke(new Action(() => search_position_result.Text = "Не найдено"));
                Invoke(new Action(() => search_time_spent.Text = $"{sw.ElapsedMilliseconds} мс."));
            }
            else
            {
                Invoke(new Action(() => search_position_result.Text = $"{pos}"));
                Invoke(new Action(() => search_time_spent.Text = $"{sw.ElapsedMilliseconds} мс."));
            }
        }
        void Search_Calculate_Best(object ct)
        {
            if (search_substring.Text == "")
            {
                Invoke(new Action(() => search_position_result.Text = "Подстрока должна содержать по крайней мере один символ."));
                Invoke(new Action(() => search_time_spent.Text = "Подстрока должна содержать по крайней мере один символ."));
                return;
            }
            CancellationToken Ca = (CancellationToken)ct;
            Stopwatch sw = new Stopwatch();
            Invoke(new Action(() => search_position_result.Text = "Происходит Вычисление ..."));
            Invoke(new Action(() => search_time_spent.Text = "Происходит Вычисление ..."));
            List<int> pos;
            if (search_register.Checked)
            {
                string temp_source = search_source.Text, temp_substring = search_substring.Text;
                sw.Start();
                pos = Strings.IndexOfKMP_Best(temp_source, temp_substring, int.Parse(search_index.Text));
            }
            else
            {
                string temp_source = search_source.Text.ToUpper(), temp_substring = search_substring.Text.ToUpper();
                sw.Start();
                pos = Strings.IndexOfKMP_Best(temp_source, temp_substring, int.Parse(search_index.Text));
            }
            sw.Stop();
            if (Ca.IsCancellationRequested)
            {
                return;
            }
            string output;
            long str_len_estimate = 0;

            for (int i = 0; i < pos.Count; i++)
            {
                str_len_estimate += pos[i].ToString().Length;
            }
            str_len_estimate += pos.Count * 5;
            long indexes = pos.Count, counter = 10, num_symb = 1;
            while (indexes > 0)
            {
                if (indexes < counter)
                {
                    str_len_estimate += indexes * num_symb;
                    break;
                }
                else
                {
                    indexes -= counter;
                }
                str_len_estimate += counter * num_symb;
                num_symb++;
                if (counter == 10)
                {
                    counter = 90;
                }
                else
                {
                    counter *= 10;
                }
            }
            char[] chars = new char[str_len_estimate];
            long index = 0, count = 0;
            for (int i = 0; i < pos.Count; i++)
            {
                string number = pos[i].ToString(), cou = count.ToString();
                for (int j = 0; j < cou.Length; j++)
                {
                    chars[index] = cou[j];
                    index++;
                }
                chars[index] = ' ';
                index++;
                chars[index] = '-';
                index++;
                chars[index] = ' ';
                index++;
                for (int j = 0; j < number.Length; j++)
                {
                    chars[index] = number[j];
                    index++;
                }
                chars[index] = '\r';
                index++;
                chars[index] = '\n';
                index++;
                count++;
            }
            output = new string(chars);
            if (pos.Count == 0)
            {
                Invoke(new Action(() => search_position_result.Text = "Не найдено"));
                Invoke(new Action(() => search_time_spent.Text = $"{sw.ElapsedMilliseconds} мс."));
            }
            else
            {
                Invoke(new Action(() => search_position_result.Text = output));
                Invoke(new Action(() => search_time_spent.Text = $"{sw.ElapsedMilliseconds} мс."));
            }
        }

        private void search_register_CheckedChanged(object sender, EventArgs e)
        {
            Search_Change();
        }
    }
}