using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producer_Consumer
{
    public partial class PCsynchro : Form
    {
        public PCsynchro()
        {
            InitializeComponent();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            string result = "";
            int PoolSize = int.Parse(PoolBox.Text);
            int ProducerNum = int.Parse(ProducerBox.Text);
            int ConsumerNum = int.Parse(ConsumerBox.Text);
            product[] productList = new product[PoolSize];
            int index = 0;
            object lockobj = new object();
            for (int i = 0; i < ProducerNum; i++)
            {

                new Thread(() =>
                {
                    while (true)
                    {
                        lock (lockobj)
                        {
                            if (index < PoolSize)
                            {
                                product p = new product();
                                productList[index] = p;
                                int temp = i + 1;
                                result += "生产者" + temp + "生产了一个产品:" + Thread.CurrentThread.ManagedThreadId + "\r\n";
                                index++;
                            }
                        }
                        Thread.Sleep(100);
                    }
                }).Start();
            }

            for(int i = 0; i < ConsumerNum; i++)
            {
                new Thread(() =>
                {
                    while (true)
                    {
                        lock (lockobj)
                        {
                            if (index > 0)
                            {
                                productList[index - 1] = null;
                                int temp = i + 1;
                                result += "消费者" + temp + "消费了一个产品:" + Thread.CurrentThread.ManagedThreadId + "\r\n";
                                index--;
                            }
                        }
                        Thread.Sleep(50);
                    }
                }).Start();
            }
            resultBox.Text = result;
        }
    }
    class product
    {
        string productName { get; set; }
    }
}
