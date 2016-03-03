using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Docking;
using OrderManagement.Model;
using OrderManagement.Utilities;
using DevExpress.XtraMap;
using System.Net;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using OrderManagement.CustomMarkers;
using OrderManagement.CustomeChart;
using System.Diagnostics;
using System.Reflection;
using DevExpress.XtraBars;
<<<<<<< HEAD
=======
<<<<<<< HEAD
using System.Threading;
=======
>>>>>>> origin/master
>>>>>>> origin/master



namespace OrderManagement
{
    public partial class OrderManagementForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        TPOrderQuery tpQuery;
        XmlUtility xmlUtility;
        TaskQueue taskQueue;
        List<AssistData> assistInNeedList;
        List<CommonOrder> commonInNeedList;
        List<CommonOrder> commonOrderList;
        ThematicOrder thematicOrder;
        DataNameMap dataNameMap;
        OrderDetailForm odf;
        RectLatLng selectedArea;
        ThematicOrderControl thematicOrderControl;
        CommonOrderControl coc;
        ServerMonitorControl smc;
        TaskStatusControl tsc;
        List<ThematicOrder> currentThematicOrderList = new List<ThematicOrder>();
        Boolean isTaskSelected=false;
        

        #region GMapMarker
        internal readonly GMapOverlay objects = new GMapOverlay("objects");
        internal readonly GMapOverlay polygons = new GMapOverlay("polygons");
        // marker
        GMapMarker currentMarker;
        // polygons
        GMapPolygonEx polygon;
        #endregion

        public OrderManagementForm()
        {
            InitializeComponent();
            cb_dataCategory.EditValue = "生态环境";
            dtp_startDate.EditValue = "2016-1-1";
            dtp_endDate.EditValue = "2016-2-29";
            tpQuery = new TPOrderQuery();
            xmlUtility = new XmlUtility();
            dataNameMap = new DataNameMap();
            initialMap();
        }

        private void bt_tpOrderGet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            thematicOrderControl = new ThematicOrderControl(this);
            thematicOrderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            dockManager.Clear();
            DockPanel dp = dockManager.AddPanel(DockingStyle.Bottom);

            //dp.Visibility = DockVisibility.AutoHide;
            dp.Text = "专题产品订单";
            dp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dp.Controls.Add(thematicOrderControl);

            DateTime sd, ed;
            try
            {
                if (DateTime.TryParse(dtp_startDate.EditValue.ToString(), out sd) && DateTime.TryParse(dtp_endDate.EditValue.ToString(), out ed))
                {
                    string queryParam = tpQuery.GenerateQueryParam(cb_dataCategory.EditValue.ToString(), sd.ToString("yyyy-MM-dd"), ed.ToString("yyyy-MM-dd"));
                    string queryResult = tpQuery.ExcuteQuery(queryParam);
<<<<<<< HEAD
=======

                    if(queryResult == null)
                    {
                        return;
                    }

>>>>>>> origin/master
                    DataTable dt = DataBaseUtility.DataSelect("select * from TASK_ORDER");
                    DataTable dt2 = DataBaseUtility.DataSelect("select * from TASK_ORDER_STATUS");
                    //根据订单编号移除已存在订单
                    List<ThematicOrder> thematicOrderList = xmlUtility.retriveThematicOrder(queryResult);
                    foreach (ThematicOrder totmp in thematicOrderList)
                    {
                        if (dt.Select("TASK_ORDER_ID='" + totmp.Orderid + "'").Length != 0)//查看数据库中是否存在该订单
                        {
                            totmp.IsInDataBase = true;
                            //判断是否是本地订单
                            DataRow tmp = dt.Select("TASK_ORDER_ID='" + totmp.Orderid + "'")[0];
                            if (tmp["SOURCE"].ToString().Contains("本地"))
                            {
                                totmp.IsLocalOrder = true;
                            }
                            else
                                totmp.IsLocalOrder = false;
                            if(dt2.Select("TASK_ORDER_ID='" + totmp.Orderid + "'").Length != 0)//查看TASK_ORDER_STATUS表中有无该订单的状态
                            {
                                DataRow row = dt2.Select("TASK_ORDER_ID='" + totmp.Orderid + "'")[0];
                                switch (row["STATUS_SECTION"].ToString())
                                {
                                    case "已拒绝": totmp.Status = OrderStatus.已拒绝; break;
                                    case "等待数据": totmp.Status = OrderStatus.等待数据; break;
                                    case "等待生产队列": totmp.Status = OrderStatus.等待生产队列; break;
                                    case "生产中": totmp.Status = OrderStatus.生产中; break;
                                    case "生产完成": totmp.Status = OrderStatus.生产完成; break;
                                    case "未处理": totmp.Status = OrderStatus.未处理; break;
                                }
                            }
                            else
                            {
                                totmp.Status = OrderStatus.未处理;
                            }
                            
                        }
                        else
                        {
                            DataRow newRow = dt.NewRow();
                            newRow["TASK_ORDER_ID"] = totmp.Orderid;
                            if(totmp.IsLocalOrder)
                            {
                                newRow["SOURCE"] = "本地";
                            }
                            else
                            {
                                newRow["SOURCE"] = "服务运营系统";
                            }
                            newRow["CREATE_DATE"] = totmp.OrderDate;
                            newRow["PRODUCT_NAME"] = totmp.ProductName;
                            newRow["PRODUCT_TYPE"] = totmp.ProductType;
                            newRow["START_DATE"] = totmp.StartDate;
                            newRow["END_DATE"] = totmp.EndDate;
                            newRow["LEFT_TOP_LON"] = totmp.CoverScope.Split(',')[0];
                            newRow["LEFT_TOP_LAT"] = totmp.CoverScope.Split(',')[1];
                            newRow["RIGHT_BOTTOM_LON"] = totmp.CoverScope.Split(',')[2];
                            newRow["RIGHT_BOTTOM_LAT"] = totmp.CoverScope.Split(',')[3];
                            newRow["ENGLISH_NAME"] = totmp.EnglishName;
                            dt.Rows.Add(newRow);
                            DataBaseUtility.DataUpdate("TASK_ORDER",dt);

                        }
                    }
                    if (thematicOrderControl.Controls[0] is DataGridView)
                    {
                        ((DataGridView)thematicOrderControl.Controls[0]).DataSource = thematicOrderList;
                    }
                    AddOrderMarker(thematicOrderList);
                   

                
                }
            }
            catch (NullReferenceException e1)
            {
<<<<<<< HEAD
                MessageBox.Show("请输入查询参数");
=======

                MessageBox.Show("请输入查询参数", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

>>>>>>> origin/master
            }
        }

        public void AddOrderMarker(List<ThematicOrder> thematicOrderList)
        {
            polygons.Polygons.Clear();
            
            foreach (ThematicOrder to in thematicOrderList)
            {
                List<PointLatLng> polygonPoints = new List<PointLatLng>();
                string[] tmp = to.CoverScope.Split(',');
                if (tmp.Length == 4)
                {
                    PointLatLng leftUperPoint = new PointLatLng(Double.Parse(tmp[1]), Double.Parse(tmp[0]));
                    polygonPoints.Add(leftUperPoint);
                    PointLatLng rightUperPoint = new PointLatLng(Double.Parse(tmp[3]), Double.Parse(tmp[0]));
                    polygonPoints.Add(rightUperPoint);
                    PointLatLng leftDownerPoint = new PointLatLng(Double.Parse(tmp[3]), Double.Parse(tmp[2]));
                    polygonPoints.Add(leftDownerPoint);
                    PointLatLng rightDownerPoint = new PointLatLng(Double.Parse(tmp[1]), Double.Parse(tmp[2]));
                    polygonPoints.Add(rightDownerPoint);
                }

                RegeneratePolygon(polygonPoints, to.Orderid);
            }

        }

        public void AddCommonOrderMarker(List<CommonOrder> thematicOrderList)
        {
            polygons.Polygons.Clear();

            foreach (CommonOrder co in thematicOrderList)
            {
                List<PointLatLng> polygonPoints = new List<PointLatLng>();
                string[] tmp = co.CoverScope.Split(',');
                if (tmp.Length == 4)
                {
                    PointLatLng leftUperPoint = new PointLatLng(Double.Parse(tmp[1]), Double.Parse(tmp[0]));
                    polygonPoints.Add(leftUperPoint);
                    PointLatLng rightUperPoint = new PointLatLng(Double.Parse(tmp[3]), Double.Parse(tmp[0]));
                    polygonPoints.Add(rightUperPoint);
                    PointLatLng leftDownerPoint = new PointLatLng(Double.Parse(tmp[3]), Double.Parse(tmp[2]));
                    polygonPoints.Add(leftDownerPoint);
                    PointLatLng rightDownerPoint = new PointLatLng(Double.Parse(tmp[1]), Double.Parse(tmp[2]));
                    polygonPoints.Add(rightDownerPoint);
                }

                RegeneratePolygon(polygonPoints, co.Orderid);
            }

        }


        void RegeneratePolygon(List<PointLatLng> polygonPoints, string orderId)
        {
            polygon = new GMapPolygonEx(polygonPoints, orderId);
            polygon.orderId = orderId;
            polygon.IsHitTestVisible = true;
            polygons.Polygons.Add(polygon);
        }

        public void ShowSelectedOrderInMap(string orderId,ThematicTaskStatus taskStatus)
        {

            foreach (GMapPolygon r in polygons.Polygons)
            {
                if (r is GMapPolygonEx)
                {
                    GMapPolygonEx rEx = (GMapPolygonEx)r;
                    if (rEx.orderId.Equals(orderId))
                    {
                        rEx.IsSelected(taskStatus);
                        this.gMap.Position = new PointLatLng(rEx.Points[0].Lat, rEx.Points[0].Lng);
                        
                    }
                    else
                    {
                        rEx.IsUnselected();
                    }

                    this.gMap.Refresh();
                }

            }

        }


        private void initialMap()
        {
            //MapDataProviderBase provider = null;
            //provider = CreateBingDataProvider(BingMapKind.Hybrid);
            //UpdateDataProvider(provider);
            //provider.WebRequest += provider_WebRequest;
            //  this.mapControl.ZoomLevel = 3D;

            gMap.MapProvider = GMap.NET.MapProviders.BingHybridMapProvider.Instance;

<<<<<<< HEAD
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
=======

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

>>>>>>> origin/master
            gMap.Overlays.Add(polygons);
            gMap.Overlays.Add(objects);
            currentMarker = new GMarkerGoogle(gMap.Position, GMarkerGoogleType.arrow);
            currentMarker.IsHitTestVisible = false;
            //gMap.
            //gMap.SetPositionByKeywords("Maputo, Mozambique"); 
        }

        private void provider_WebRequest(object sender, MapWebRequestEventArgs e)
        {
            e.Proxy = new MyProxy();
        }

        protected BingMapDataProvider CreateBingDataProvider(BingMapKind kind)
        {
            return new BingMapDataProvider() { BingKey = "AhmMXztDbGcBH8g2mV1GhK2JmiO_Uc2dYUkLC2uhseK7dj8b2O19Ik4mNPqoAASP", Kind = kind };
        }

        void UpdateDataProvider(MapDataProviderBase provider)
        {
            //ImageTilesLayer.DataProvider = provider;
        }

        public class MyProxy : IWebProxy
        {

            private ICredentials privateCredentials;
            public ICredentials Credentials
            {
                get { return privateCredentials; }
                set { privateCredentials = value; }
            }

            public Uri GetProxy(Uri destination)
            {
                return destination;
            }

            public bool IsBypassed(Uri host)
            {
                return true;
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            coc = new CommonOrderControl(this);
            coc.Dock = System.Windows.Forms.DockStyle.Fill;
            dockManager.Clear();
            DockPanel dp = dockManager.AddPanel(DockingStyle.Bottom);

            dp.Text = "共性产品订单";
            dp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dp.Controls.Add(coc);

            DataTable dt = DataBaseUtility.DataSelect("select * from GXORDER");
            this.commonOrderList = new List<CommonOrder>();
            if (dt == null)
            {
<<<<<<< HEAD
                MessageBox.Show("查询未返回结果");
=======

                MessageBox.Show("查询未返回结果", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

>>>>>>> origin/master
                return;
            }
            foreach(DataRow row in dt.Rows)
            {
                CommonOrder co = new CommonOrder();
                co.Orderid = row["COMM_ORDER_ID"].ToString();
                co.ProductName = row["PRODUCTNAME"].ToString();
                co.ProductType = row["PRODUCTTYPE"].ToString();
                co.CoverScope = row["COVERSCOPE"].ToString();
                co.StartDate = row["STARTDATE"].ToString();
                co.EndDate = row["ENDDATE"].ToString();
                co.OrderDate = row["CREATEDAT"].ToString();
                co.UpdateDate = row["LASTUPDATEDAT"].ToString();
                co.Status = row["STATUS"].ToString();
                this.commonOrderList.Add(co);
            }
            if (coc.Controls[0] is DataGridView)
            {
                ((DataGridView)coc.Controls[0]).DataSource = commonOrderList;
            }
            AddCommonOrderMarker(this.commonOrderList);
            //TODO:添加共性产品订单的标记至地图
        }

        private void mapControl_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.odf = new OrderDetailForm(this);

            odf.EnableAddLocalThematicOrder();
            odf.Show();
            odf.BringToFront();

        }

        public string GetSelectedAreaLatLon()
        {
           //RectLatLng area =  gMap.SelectedArea;
            if (selectedArea != null)
            {
                PointLatLng topleftp = selectedArea.LocationTopLeft;
                PointLatLng downrightp = selectedArea.LocationRightBottom;
                string coverrage = topleftp.Lng.ToString() + "," + topleftp.Lat.ToString() + "," + downrightp.Lng.ToString() + "," + downrightp.Lat.ToString();
                return coverrage;
            }
            else
            {
                return "0,0,0,0";
            }



        }

        public void ClearMap()
        {
            polygons.Clear();
        }

        private void btOrderQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            thematicOrderControl = new ThematicOrderControl(this);
            thematicOrderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            dockManager.Clear();
            DockPanel dp = dockManager.AddPanel(DockingStyle.Bottom);

            //dp.Visibility = DockVisibility.AutoHide;
            dp.Text = "专题产品订单";
            dp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dp.Controls.Add(thematicOrderControl);

            DateTime sd, ed;
            try
            {
                if (DateTime.TryParse(dtp_startDate.EditValue.ToString(), out sd) && DateTime.TryParse(dtp_endDate.EditValue.ToString(), out ed))
                {
                    string queryParam = @"select * from TASK_ORDER where CREATE_DATE>= to_date('" + sd.ToString("yyyy-MM-dd") + "','yyyy-MM-dd') and CREATE_DATE<=to_date('" + ed.ToString("yyyy-MM-dd") + "','yyyy-MM-dd')";
                    DataTable dt = DataBaseUtility.DataSelect(queryParam);
                    DataTable dt2 = DataBaseUtility.DataSelect("select * from TASK_ORDER_STATUS");
                    List<ThematicOrder> thematicOrderList = new List<ThematicOrder>();
                    if (dt == null)
                    {
<<<<<<< HEAD
                        MessageBox.Show("查询未返回结果");
=======

                        MessageBox.Show("查询未返回结果", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

>>>>>>> origin/master
                        return;
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        ThematicOrder to = new ThematicOrder();
                        to.Orderid = row["TASK_ORDER_ID"].ToString();
                        if (row["SOURCE"].ToString().Contains("本地"))
                        {
                            to.IsLocalOrder = true;
                        }else
                        {
                            to.IsLocalOrder = false;
                        }
                        to.OrderDate = row["CREATE_DATE"].ToString();
                        to.ProductName = row["PRODUCT_NAME"].ToString();
                        to.EnglishName = dataNameMap.GetThematicEnglishName(to.ProductName);
                        to.ProductType = row["PRODUCT_TYPE"].ToString();
                        to.StartDate = row["START_DATE"].ToString();
                        to.EndDate = row["END_DATE"].ToString();
                        to.CoverScope = row["LEFT_TOP_LON"].ToString() + "," + row["LEFT_TOP_LAT"].ToString() + "," + row["RIGHT_BOTTOM_LON"].ToString() + ","+row["RIGHT_BOTTOM_LAT"].ToString();
                        to.IsInDataBase = true;
                        //to.Status = OrderStatus.未处理;
                        if (dt2.Select("TASK_ORDER_ID='" + to.Orderid + "'").Length != 0)//查看TASK_ORDER_STATUS表中有无该订单的状态
                        {
                            DataRow row1 = dt2.Select("TASK_ORDER_ID='" + to.Orderid + "'")[0];
                            switch (row1["STATUS_SECTION"].ToString())
                            {
                                case "已拒绝": to.Status = OrderStatus.已拒绝; break;
                                case "等待数据": to.Status = OrderStatus.等待数据; break;
                                case "等待生产队列": to.Status = OrderStatus.等待生产队列; break;
                                case "生产中": to.Status = OrderStatus.生产中; break;
                                case "生产完成": to.Status = OrderStatus.生产完成; break;
                                case "未处理": to.Status = OrderStatus.未处理; break;
                            }
                        }
                        else
                        {
                            to.Status = OrderStatus.未处理;
                        }

                        thematicOrderList.Add(to);
                    }
                    if (thematicOrderControl.Controls[0] is DataGridView)
                    {
                        ((DataGridView)thematicOrderControl.Controls[0]).DataSource = thematicOrderList;
                    }
                    AddOrderMarker(thematicOrderList);
                }
            }
            catch (NullReferenceException e1)
            {
<<<<<<< HEAD
                MessageBox.Show("请输入查询参数");
=======

                MessageBox.Show("请输入查询参数", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

>>>>>>> origin/master
            }
        }

        private void gMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if(gMap.SelectedArea!=null&&)
            
            if(this.odf!=null)
            {
                if(this.odf.IsMapSelection==true)
                {
                    this.odf.SetCoverRage(GetSelectedAreaLatLon());
                }
                this.odf.BringToFront();
                //this.odf.TopMost = true;
            }
        }

        private void gMap_OnSelectionChange(RectLatLng Selection, bool ZoomToFit)
        {
            this.selectedArea = gMap.SelectedArea;
        }

        private void bt_CommonOrderStatusUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.coc != null)
            {
                //this.thematicOrderControl.retriveOrder();
                this.coc.updateCommonOrderStatus();
            }
            else
            {
<<<<<<< HEAD
                MessageBox.Show("请先查看共性产品需求，并选中需更新状态的需求订单");
=======

                MessageBox.Show("请先查看共性产品需求，并选中需更新状态的需求订单", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

>>>>>>> origin/master
            }
        }
        

        private void bt_OrderRetrive_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(this.thematicOrderControl!=null)
            {
                this.thematicOrderControl.retriveOrder();
            }
            else
            {
<<<<<<< HEAD
                MessageBox.Show("请先获取订单，并选中需解析的订单");
=======

                MessageBox.Show("请先获取订单，并选中需解析的订单", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

>>>>>>> origin/master
            }
        }

        private void bt_CommonOrderSubmit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
<<<<<<< HEAD
            MessageBox.Show("暂无测试数据，等待课题3跟进");
=======

            if(this.coc==null)
            {
                MessageBox.Show("请先查看共性需求列表，并选中完成生产的共性产品需求", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else{
                this.coc.downloadDataToLocal();
            }

>>>>>>> origin/master
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
<<<<<<< HEAD
            MessageBox.Show("该接口还有问题");
=======

            if(this.thematicOrderControl==null)
            {
                MessageBox.Show("请先获取专题产品订单列表，并选中已完成生产的专题产品订单", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                this.thematicOrderControl.PublishThematicData();
            }

>>>>>>> origin/master
        }

        private void btGetMonitInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //通过http协议获得节点信息
            //HardwareMonitor hardwareMonitor = new HardwareMonitor();
            //String result = hardwareMonitor.GetMonitorResult("202.205.84.114");
            //if(result!=null)
            //{
            //  Sensors sensors =  JsonUtility.GetSensors(result);
            //  hardwareMonitor.GetChildrenById(sensors, 18);
            //  Sensors memorySensor = hardwareMonitor.TargetSensor;
            //  if(memorySensor!=null)
            //  { 
            //    Console.WriteLine(memorySensor.Id);
            //  }
            //}
            if (this.smc != null)
            {
                this.smc.getServerInfo();
            }
            else
            {
<<<<<<< HEAD
                MessageBox.Show("请先查看节点列表，并选中某一生产节点");
=======

                MessageBox.Show("请先查看节点列表，并选中某一生产节点","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);

>>>>>>> origin/master
            }

            //ServerMonitorControl smc = new ServerMonitorControl();
            //smc.Dock = System.Windows.Forms.DockStyle.Fill;
            //dockManager.Clear();
            //DockPanel dp = dockManager.AddPanel(DockingStyle.Right);
            //dp.Text = "生产节点监控";
            //dp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //dp.Width = 600;
            //dp.Controls.Add(smc);
        }

        private void btAddSever_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
<<<<<<< HEAD
            try { 
            this.smc = new ServerMonitorControl();
            this.smc.AddServerNode(tbServerName.EditValue.ToString(), tbServerAddr.EditValue.ToString(), int.Parse(tbServerPort.EditValue.ToString()));
            showServerMonitorControl();
            //将节点添加到数据库或配置文件中
            MessageBox.Show("添加成功，点击节点状态查看节点情况。");
                }
            catch(NullReferenceException e1)
=======

            try
            {
                this.smc = new ServerMonitorControl();

                bool isAddSuccess = this.smc.AddServerNode(tbServerName.EditValue.ToString(), tbServerAddr.EditValue.ToString(), int.Parse(tbServerPort.EditValue.ToString()));
                if (isAddSuccess)
                {
                    showServerMonitorControl();
                    MessageBox.Show("添加成功，点击节点状态查看节点情况。");
                }
            }
            catch (NullReferenceException e1)

>>>>>>> origin/master
            {
                MessageBox.Show("请将节点信息填写完整");
            }
        }

        private void showServerMonitorControl()
        {
            //ServerMonitorControl smc = new ServerMonitorControl();
            if (this.smc == null)
                return;
            this.smc.Dock = System.Windows.Forms.DockStyle.Fill;
            dockManager.Clear();
            DockPanel dp = dockManager.AddPanel(DockingStyle.Right);
            dp.Text = "生产节点监控";
            dp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dp.Width = 600;

            DataTable dt = DataBaseUtility.DataSelect("select * from SERVERNODE");
            List<ServerNode> serverNodeList = new List<ServerNode>();
            if (dt == null)
            {
                MessageBox.Show("查询未返回结果,请检查数据库!");
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                ServerNode co = new ServerNode();
                co.Id = int.Parse(row["ID"].ToString());
                co.NodeName = row["NODE_NAME"].ToString();
                co.NodeIp = row["NODE_IP"].ToString();
                co.Port = int.Parse(row["NODE_PORT"].ToString());
                co.Status = row["NODE_STATUS"].ToString();
                co.TaskNum = int.Parse(row["TASK_NUM"].ToString());
                serverNodeList.Add(co);
            }
            for(int i=0;i<this.smc.Controls.Count;i++)
            { 
                if (this.smc.Controls[i] is DataGridView)
                {
                    ((DataGridView)this.smc.Controls[i]).DataSource = serverNodeList;
                    break;
                }
            }
            dp.Controls.Add(this.smc);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.smc = new ServerMonitorControl();
            showServerMonitorControl();
        }

        

        private void showTaskStatus()
        {
            
            if (this.tsc == null)
                return;
            this.tsc.Dock = System.Windows.Forms.DockStyle.Fill;
            dockManager.Clear();
            DockPanel dp = dockManager.AddPanel(DockingStyle.Bottom);
            dp.Text = "生产任务情况";
            dp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dp.Width = 600;

            DataTable dt = DataBaseUtility.DataSelect("select * from TASK_ORDER_STATUS");
            List<ThematicTaskStatus> thematicTaskStatusList = new List<ThematicTaskStatus>();
            if (dt == null)
            {
                MessageBox.Show("查询未返回结果,请检查数据库!");
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                ThematicTaskStatus co = new ThematicTaskStatus();
                co.ThematicId = row["TASK_ORDER_ID"].ToString();
                switch(row["STATUS_SECTION"].ToString())
                {
                    case "已拒绝": co.TaskStatus = OrderStatus.已拒绝; break;
                    case "等待数据": co.TaskStatus = OrderStatus.等待数据; break;
                    case "等待生产队列": co.TaskStatus = OrderStatus.等待生产队列; break;
                    case "生产中": co.TaskStatus = OrderStatus.生产中; break;
                    case "生产完成": co.TaskStatus = OrderStatus.生产完成; break;
                    case "未处理": co.TaskStatus = OrderStatus.未处理; break;
                }
                co.StatusDes = row["STATUS_DESC"].ToString();
                co.NodeIp = row["NODE_IP"].ToString();
                co.NodeName= row["NODE_NAME"].ToString();
                co.IsLastStatus = true;
                Console.WriteLine(row["LASTUPDATEDAT"].ToString());
                co.LastUpdateTime =DateTime.Parse(row["LASTUPDATEDAT"].ToString());
                thematicTaskStatusList.Add(co);
            }
            for (int i = 0; i < this.tsc.Controls.Count; i++)
            {
                if (this.tsc.Controls[i] is DataGridView)
                {
                    ((DataGridView)this.tsc.Controls[i]).DataSource = thematicTaskStatusList;
                    break;
                }
            }
            dp.Controls.Add(this.tsc);
        }

        private void btTaskStatus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tsc = new TaskStatusControl();
            this.showTaskStatus();
        }

        private void btSTXTLXMJBHL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            ExecuteProductFunc( this.GetMethodName());
        }


        private void ExecuteProductFunc(string funcName)
        {
            string exeName = funcName.Substring(2, funcName.LastIndexOf('_') - 2);
            Process p = Process.Start(Application.StartupPath + "\\EXE\\" + exeName + ".exe");
        }

        public  string GetMethodName()
        {
            var method = new StackFrame(1).GetMethod(); // 这里忽略1层堆栈，也就忽略了当前方法GetMethodName，这样拿到的就正好是外部调用GetMethodName的方法信息
            var property = (
            from p in method.DeclaringType.GetProperties(
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.Public |
            BindingFlags.NonPublic)
            where p.GetGetMethod(true) == method || p.GetSetMethod(true) == method
            select p).FirstOrDefault();
            return property == null ? method.Name : property.Name;
        }

        private void gMap_Load(object sender, EventArgs e)
        {

        }

        private void btJJDZS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btJGPSD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btJGDYXZS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btSTXTHGJG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btJGFLD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btRLHDGRQD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btHMHZS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btXGBHL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btSTXTWDXZS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btCDTHZS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btHPMJBHL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btQQHJJCZS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btZBSFLYXL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btSTXTMGXZS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btCYGHZS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btSYHYL_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btTGDL_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btFSQTRQSMS_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        private void btSSQTRQSMS_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExecuteProductFunc(this.GetMethodName());
        }

        //查看任务队列
        private void btViewTaskList_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.tsc = new TaskStatusControl(this);
            this.showTaskList();
        }

        private void showTaskList()
        {
            if (this.tsc == null)
                return;
            this.tsc.Dock = System.Windows.Forms.DockStyle.Fill;
            dockManager.Clear();
            DockPanel dp = dockManager.AddPanel(DockingStyle.Bottom);
            dp.Text = "生产队列情况";
            dp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dp.Width = 600;

<<<<<<< HEAD
            DataTable dt = DataBaseUtility.DataSelect("select * from TASK_ORDER_STATUS where STATUS_SECTION ='等待生产队列' OR STATUS_SECTION ='生产中' ");
=======
            DataTable dt = DataBaseUtility.DataSelect("select * from TASK_ORDER_STATUS where STATUS_SECTION ='等待生产队列' ");
>>>>>>> origin/master
            List<ThematicTaskStatus> thematicTaskStatusList = new List<ThematicTaskStatus>();
            if (dt == null)
            {
                MessageBox.Show("查询未返回结果,请检查数据库!");
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                ThematicTaskStatus co = new ThematicTaskStatus();
                co.ThematicId = row["TASK_ORDER_ID"].ToString();
                switch (row["STATUS_SECTION"].ToString())
                {
                    case "已拒绝": co.TaskStatus = OrderStatus.已拒绝; break;
                    case "等待数据": co.TaskStatus = OrderStatus.等待数据; break;
                    case "等待生产队列": co.TaskStatus = OrderStatus.等待生产队列; break;
                    case "生产中": co.TaskStatus = OrderStatus.生产中; break;
                    case "生产完成": co.TaskStatus = OrderStatus.生产完成; break;
                    case "未处理": co.TaskStatus = OrderStatus.未处理; break;
                }
                co.StatusDes = row["STATUS_DESC"].ToString();
                co.NodeIp = row["NODE_IP"].ToString();
                co.NodeName = row["NODE_NAME"].ToString();
                co.IsLastStatus = true;
                Console.WriteLine(row["LASTUPDATEDAT"].ToString());
                co.LastUpdateTime = DateTime.Parse(row["LASTUPDATEDAT"].ToString());
                thematicTaskStatusList.Add(co);
            }
            for (int i = 0; i < this.tsc.Controls.Count; i++)
            {
                if (this.tsc.Controls[i] is DataGridView)
                {
                    ((DataGridView)this.tsc.Controls[i]).DataSource = thematicTaskStatusList;
                    break;
                }
            }
            dp.Controls.Add(this.tsc);            
            List<ThematicOrder> thematicOrderList=getThematicOrdersInTaskList();
            AddOrderMarker(thematicOrderList);
        }

        private List<ThematicOrder> getThematicOrdersInTaskList()
        {
            DataTable dt = DataBaseUtility.DataSelect("select * from TASK_ORDER");
            DataTable dt2 = DataBaseUtility.DataSelect("select * from TASK_ORDER_STATUS");

            List<ThematicOrder> thematicOrderList = new List<ThematicOrder>();

            if (dt == null)
            {
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                ThematicOrder to = new ThematicOrder();
                to.Orderid = row["TASK_ORDER_ID"].ToString();
                if (row["SOURCE"].ToString().Contains("本地"))
                {
                    to.IsLocalOrder = true;
                }
                else
                {
                    to.IsLocalOrder = false;
                }
                to.OrderDate = row["CREATE_DATE"].ToString();
                to.ProductName = row["PRODUCT_NAME"].ToString();
                to.ProductType = row["PRODUCT_TYPE"].ToString();
                to.StartDate = row["START_DATE"].ToString();
                to.EndDate = row["END_DATE"].ToString();
                to.CoverScope = row["LEFT_TOP_LON"].ToString() + "," + row["LEFT_TOP_LAT"].ToString() + "," + row["RIGHT_BOTTOM_LON"].ToString() + "," + row["RIGHT_BOTTOM_LAT"].ToString();
                to.IsInDataBase = true;
                if (dt2.Select("TASK_ORDER_ID='" + to.Orderid + "'").Length != 0)//查看TASK_ORDER_STATUS表中有无该订单的状态
                {
                    DataRow row1 = dt2.Select("TASK_ORDER_ID='" + to.Orderid + "'")[0];
                    switch (row1["STATUS_SECTION"].ToString())
                    {
                        case "已拒绝": to.Status = OrderStatus.已拒绝; break;
                        case "等待数据": to.Status = OrderStatus.等待数据; break;
                        case "等待生产队列": to.Status = OrderStatus.等待生产队列; break;
                        case "生产中": to.Status = OrderStatus.生产中; break;
                        case "生产完成": to.Status = OrderStatus.生产完成; break;
                        case "未处理": to.Status = OrderStatus.未处理; break;
                    }
                }
                else
                {
                    to.Status = OrderStatus.未处理;
                }

                if (to.Status.Equals(OrderStatus.等待生产队列))
                {
                    thematicOrderList.Add(to);
                }

            }

            return thematicOrderList;
        }
       

        private void btProduce_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.tsc != null)
            {
                this.tsc.invokeServiceToProduce(); ;
            }
            else
            {
                MessageBox.Show("请先获取生产队列，并选中需进行配置的生产任务");
            }
            
        }

        private void btTaskConfig_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.tsc != null)
            {
                this.tsc.taskParameterConfig();
            }
            else
            {
                MessageBox.Show("请先获取生产队列，并选中需进行配置的生产任务");
            }
        }

        private void bt_downloadResultImg_ItemClick(object sender, ItemClickEventArgs e)
        {            
            if (this.tsc != null)
            {
<<<<<<< HEAD
                this.tsc.downloadDataToLocal(); ;
            }
=======

                this.tsc.downloadDataToLocal();             }

>>>>>>> origin/master
            else
            {
                MessageBox.Show("请先获取生产队列，再选择已生产完成的订单");
            }
        }

<<<<<<< HEAD
       
=======
        private void btDeleteNode_ItemClick(object sender, ItemClickEventArgs e)
        {

            try
            {
                //this.smc = new ServerMonitorControl();
                this.smc.DeleteSeverNode();
            }
            catch (NullReferenceException e1)
            {
                //MessageBox.Show("请将节点信息填写完整");
            }
        }

>>>>>>> origin/master
      
    }

    
}

  
