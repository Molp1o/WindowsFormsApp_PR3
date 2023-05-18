using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp_PR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int create_btn_clicked = 0;
        Dictionary<int, int> sequence;
        Dictionary<int, int> dict_create(IEnumerable<int> list)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int item in list)
            {
                int res;
                if (dict.TryGetValue(item, out res))
                {
                    dict[item] += 1;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }
            return dict;
        }
        private void create_btn_Click(object sender, EventArgs e)
        {
            create_btn_clicked++;
            try
            {
                if (Int32.Parse(el_amnt_tb.Text) > 25)
                {
                    errorProvider1.SetError(el_amnt_tb, "Кол-во элементов не может превышать 25!");
                }
                else if (Int32.Parse(el_amnt_tb.Text) <= 0)
                {
                    errorProvider1.SetError(el_amnt_tb, "Кол-во элементов не может быть меньше или равно 0!");
                }
                else
                {
                    mst_cmn_tb.Clear();
                    mst_cmn_lbl.Text = "(Здесь будет выведено кол-во повторений)";
                    mst_cmn_key_lbl.Text = "(Здесь будут выведины числа, которые повторяются)";
                    errorProvider1.Clear();
                    List<int> list = new List<int>();
                    Random random = new Random();
                    for (int i = 0; i < Int32.Parse(el_amnt_tb.Text); i++)
                    {
                        list.Add(random.Next(0, 9));

                    }
                    sequence = dict_create(list);
                    list_lbl.Text = null;
                    foreach (int item in list)
                    {
                        list_lbl.Text += item.ToString() + " ";
                    }
                }
            }
            catch (FormatException fe)
            {
                errorProvider1.SetError(el_amnt_tb, fe.Message);
            }
            catch (OverflowException ofe)
            {
                errorProvider1.SetError(el_amnt_tb, ofe.Message);
            }
        }
        private void mst_cmn_btn_Click(object sender, EventArgs e)
        {

            try
            {
                if (create_btn_clicked == 0)
                {
                    errorProvider1.SetError(mst_cmn_tb, "Нужно создать лист!");
                }
                else if (sequence is null)
                {
                    errorProvider1.SetError(mst_cmn_tb, "Кол-во элементов не может быть меньше или равно 0!");
                }
                else if (Int32.Parse(mst_cmn_tb.Text) > sequence.Keys.Count)
                {
                    errorProvider1.SetError(mst_cmn_tb, "Кол-во элементов не может превышать количество разных значений последовательности!");
                }
                else if (Int32.Parse(mst_cmn_tb.Text) <= 0)
                {
                    errorProvider1.SetError(mst_cmn_tb, "Кол-во элементов не может быть меньше или равно 0!");
                }
                else
                {
                    errorProvider1.Clear();
                    sequence = sequence.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                    int counter = 0;
                    int key_counter = 0;
                    mst_cmn_lbl.Text = null;
                    mst_cmn_key_lbl.Text = null;
                    foreach (int item in sequence.Values)
                    {
                        mst_cmn_lbl.Text += item.ToString() + " ";
                        counter++;
                        if (counter == Int32.Parse(mst_cmn_tb.Text))
                        {
                            break;
                        }
                    }
                    foreach (int item in sequence.Keys)
                    {
                        mst_cmn_key_lbl.Text += item.ToString() + " ";
                        key_counter++;
                        if (key_counter == Int32.Parse(mst_cmn_tb.Text))
                        {
                            break;
                        }
                    }
                }
            }
            catch (FormatException fe)
            {
                errorProvider1.SetError(mst_cmn_tb, fe.Message);
            }
            catch (OverflowException ofe)
            {
                errorProvider1.SetError(mst_cmn_tb, ofe.Message);
            }
            catch (NullReferenceException nre)
            {
                errorProvider1.SetError(mst_cmn_tb, nre.Message);
            }
        }
        private void list_lbl_Click(object sender, EventArgs e)
        {

        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void очиститьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            list_lbl.Text = "(Здесь появится ваша последовательность)";
            el_amnt_tb.Clear();
            mst_cmn_tb.Clear();
            mst_cmn_lbl.Text = "(Здесь будет выведено кол-во повторений)";
            mst_cmn_key_lbl.Text = "(Здесь будут выведины числа, которые повторяются)";
        }
    }
}
