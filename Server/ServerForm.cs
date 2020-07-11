using System;
using Server;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting;
using System.Collections;
using System.Net;
using General;

namespace Server
{
    public partial class ServerForm : Form
    {
        private Bitmap bmpbackg = new Bitmap("..//..//backg.jpg");
        private int Port = 6123;
        private Hashtable OnlineUserList; //bảng băm
        public int i = 0;
        public  string[] Usenames = new string[100];
        public ServerForm()
        {
            InitializeComponent();
            
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = bmpbackg;
            BackgroundImageLayout = ImageLayout.Stretch;
            String hostName = Dns.GetHostName();// lấy địa chỉ IP đã có
            BinaryClientFormatterSinkProvider clientProvider = new BinaryClientFormatterSinkProvider();//tạo máy khách dùng BinaryFormatter để truyền hông điệp
            BinaryServerFormatterSinkProvider serverProvider = new BinaryServerFormatterSinkProvider();
            serverProvider.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;//bộ lọc
            IDictionary props = new Hashtable();//từ điển
            props["port"] = Port;
            props["typeFilterLevel"] = TypeFilterLevel.Full;

            HttpChannel chan = new HttpChannel(props, clientProvider, serverProvider);            
            ChannelServices.RegisterChannel(chan, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteObject), "RemoteObject.soap", WellKnownObjectMode.SingleCall);

            AddTextToDisplay("Đang mở Port  " + Port + "..." + hostName);
            OnlineUserList = new Hashtable();
        }

        delegate void AddTextToDisplayDelegate(String Info);
        public void AddTextToDisplay(String Info)
        {
            if (this.InvokeRequired)
            {
                AddTextToDisplayDelegate d = new AddTextToDisplayDelegate(AddTextToDisplay);
                this.Invoke(d, Info);
            }
            else
            {
                this.txtDisplay.AppendText(Environment.NewLine + "#" + Info);
            }
            
        }

        internal void AddUserToOnlineUserList(String Username, WrapperTransporterClass wtc)
        {     
                OnlineUserList.Add(Username, wtc);
        }

        internal void ModifyUserOnlineListWrapper(String Username, WrapperTransporterClass wtc)
        {
            OnlineUserList[Username] = wtc;
        }

        internal WrapperTransporterClass GetConnectionTo(String Username)
        {
            return (WrapperTransporterClass)OnlineUserList[Username];
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetUsername(string name)
        {
            Usenames[i]=name;
            i++;
        }
        public string GetUsername(int i)
        {
            return Usenames[i];
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
