using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NLog;

namespace PageLifeCycleDemo
{
    public partial class UserControl1 : System.Web.UI.UserControl
    {

        private Logger _logger = LogManager.GetLogger("test");

        protected override void OnInit(EventArgs e)
        {
            _logger.Trace("User Control OnInit event execute!");
            base.OnInit(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            _logger.Trace("User Control OnLoad event execute!");
            base.OnLoad(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            _logger.Trace("User Constrol OnPreRender event execute!");
            base.OnPreRender(e);
        }

        protected override void OnUnload(EventArgs e)
        {
            _logger.Trace("User Constrol OnUnload event execute!");
            base.OnUnload(e);
        }

        protected override void OnDataBinding(EventArgs e)
        {
            _logger.Trace("User Control OnDataBinding event execute!");
            base.OnDataBinding(e);
        }

        #region 伺服器控制項的事件
        protected void ucTextBox1_Unload(object sender, EventArgs e)
        {
            _logger.Trace("ucTextBox1 Unload event execute!");
        }

        protected void ucTextBox1_PreRender(object sender, EventArgs e)
        {
            _logger.Trace("ucTextBox1 PreRender event execute!");
        }

        protected void ucTextBox1_Load(object sender, EventArgs e)
        {
            _logger.Trace("ucTextBox1 Load event execute!");
        }

        protected void ucTextBox1_Init(object sender, EventArgs e)
        {
            _logger.Trace("ucTextBox1 Init event execute!");
        } 
        #endregion

    }
}