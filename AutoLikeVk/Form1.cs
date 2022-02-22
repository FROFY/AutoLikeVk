using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using xNet;
using System.Threading.Tasks;

namespace AutoLikeVk
{
    public partial class Form1 : Form
    {

        string[] tokens = { };
        string token = "";
        int post_id = 0;
        Root root;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() => MainTask());
        }

        private int getPostId()
        {
            using (HttpRequest request = new HttpRequest())
            {
                string response = request.Get($"https://api.vk.com/method/wall.get?offset=1&owner_id=-195907408&count=1&access_token={token}&v=5.126").ToString();
                root = JsonConvert.DeserializeObject<Root>(response);
                return root.response.items[0].id;
            }
        }

        private int postLike(int post_id)
        {
            using (HttpRequest request = new HttpRequest())
            {
                string response = request.Get($"https://api.vk.com/method/likes.add?type=post&owner_id=-195907408&item_id={post_id}&access_token={token}&v=5.126").ToString();
                RootNew root1 = JsonConvert.DeserializeObject<RootNew>(response);
                if (root1.response.likes == 1)
                {
                    richTextBox1.Invoke(new Action(() => richTextBox1.Text += "Лайк поставлен\n"));
                    return 1;
                }
                else
                    return 0;
            }
        }

        private async void MainTask()
        {
            while(true)
            {
                if (!checkBox1.Checked)
                {
                    if (post_id < getPostId())
                        postLike(getPostId());
                    await Task.Delay(5000);
                }
                else
                {
                    richTextBox1.Invoke(new Action(() => richTextBox1.Text += "Программа остановлена\n"));
                    await Task.Delay(-1);
                }
            }
        }
    }
}
