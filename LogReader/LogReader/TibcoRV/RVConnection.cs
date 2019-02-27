using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using TIBCO.Rendezvous;

namespace LogReader
{
    public class RVConnection
    {
        private string service;
        private string network;
        private string daemon;
        private string listenSubject;
        private string targetSubject;
        private double timeOut;
        private string setEncoding;
        private NetTransport netTtransport;
        private Queue queue;
        private Dispatcher dispatcher;
        private Listener listener;

        private string Connect(string listenSubject)
        {
            string result = "Connect Success";
            if (string.IsNullOrEmpty(listenSubject))
            {
                return "Set Listen or Target Subject First";
            }
            if (!string.IsNullOrEmpty(setEncoding))
            {
                Encoding encoding = System.Text.Encoding.GetEncoding(setEncoding);
                TIBCO.Rendezvous.Environment.StringEncoding = encoding;
            }
            TIBCO.Rendezvous.Environment.Open();
            //Service,network,daemon should be B2MES
            netTtransport = new NetTransport(service, network, daemon);
            queue = new TIBCO.Rendezvous.Queue();
            dispatcher = new Dispatcher(queue);
            //listen subject should be B2MES
            listener = new Listener(queue, netTtransport, listenSubject, null);
            listener.MessageReceived += Listener_MessageReceived;
            return result;
        }

        private void Listener_MessageReceived(object listener, MessageReceivedEventArgs messageReceivedEventArgs)
        {
            throw new NotImplementedException();
        }

        //private void btn_Connect_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.Cursor = Cursors.WaitCursor;
        //        if (btn_Connect.Text.Equals("Connect"))
        //        {
        //            if (string.IsNullOrEmpty(txt_ListenSubject.Text) || string.IsNullOrEmpty(txt_TargetSubject.Text))
        //            {
        //                MessageBox.Show("Set Listen or Target Subject First", "Error");
        //                return;
        //            }
        //            listenSubject = txt_ListenSubject.Text.Trim();
        //            if (!string.IsNullOrEmpty(setEncoding))
        //            {
        //                Encoding encoding = System.Text.Encoding.GetEncoding(setEncoding);
        //                TIBCO.Rendezvous.Environment.StringEncoding = encoding;
        //            }
        //            TIBCO.Rendezvous.Environment.Open();
        //            //Service,network,daemon should be B2MES
        //            netTtransport = new NetTransport(service, network, daemon);
        //            queue = new TIBCO.Rendezvous.Queue();
        //            dispatcher = new Dispatcher(queue);
        //            //listen subject should be B2MES
        //            listener = new Listener(queue, netTtransport, listenSubject, null);
        //            listener.MessageReceived += Listener_MessageReceived;
        //            //this.btn_Connect.Enabled = false;
        //            this.btn_Connect.Text = "Disconnect";
        //            this.btnStart.Enabled = true;
        //            this.txt_ListenSubject.Enabled = false;
        //            this.txt_TargetSubject.Enabled = false;
        //            isConnectedTIB = true;
        //        }
        //        else
        //        {
        //            isConnectedTIB = false;
        //            this.StopConnecting();
        //            this.btn_Connect.Text = "Connect";
        //            this.btnStart.Enabled = false;
        //            this.btnStop.Enabled = false;
        //            this.txt_ListenSubject.Enabled = true;
        //            this.txt_TargetSubject.Enabled = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        logProxy.LogTrace(serviceName, 1, "Exception: " + ex.Message);
        //    }
        //    finally
        //    {
        //        this.Cursor = Cursors.Default;
        //    }
        //}
    }
}
