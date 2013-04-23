using System;
using NLog;

namespace PageLifeCycleDemo
{
    public partial class Index : System.Web.UI.Page
    {
        private Logger _logger = LogManager.GetLogger("test");

        protected override void OnPreInit(EventArgs e)
        {
            _logger.Trace("OnPreInit event execute!");
            base.OnPreInit(e);
        }

        protected override void OnInit(EventArgs e)
        {
            _logger.Trace("OnInit event execute!");
            base.OnInit(e);
        }

        protected override void OnInitComplete(EventArgs e)
        {
            _logger.Trace("OnInitComplete event execute!");
            base.OnInitComplete(e);
        }

        protected override void OnPreLoad(EventArgs e)
        {
            _logger.Trace("OnPreLoad event execute!");
            base.OnPreLoad(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            _logger.Trace("OnLoad event execute!");
            base.OnLoad(e);
        }

        protected override void OnLoadComplete(EventArgs e)
        {
            _logger.Trace("OnLoadComplete event execute!");
            base.OnLoadComplete(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            _logger.Trace("OnPreRender event execute!");
            base.OnPreRender(e);
        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            _logger.Trace("OnPreRenderComplete event execute!");
            base.OnPreRenderComplete(e);
        }

        protected override void OnSaveStateComplete(EventArgs e)
        {
            _logger.Trace("OnSaveStateComplete event execute!");
            base.OnSaveStateComplete(e);
        }

        protected override void OnUnload(EventArgs e)
        {
            _logger.Trace("OnUnload event execute!");
            base.OnUnload(e);
            _logger.Trace("-------------------");
        }

        #region 伺服器控制項的事件
        protected void button1_Init(object sender, EventArgs e)
        {
            _logger.Trace("Fisrtbutton Init event execute!");
        }

        protected void button1_Load(object sender, EventArgs e)
        {
            _logger.Trace("Fisrtbutton Load event execute!");
        }

        protected void button1_PreRender(object sender, EventArgs e)
        {
            _logger.Trace("Fisrtbutton PreRender event execute!");
        }

        protected void button1_Unload(object sender, EventArgs e)
        {
            _logger.Trace("Fisrtbutton Unload event execute!");
        }
        protected void button2_Init(object sender, EventArgs e)
        {
            _logger.Trace("Secondbutton Init event execute!");
        }

        protected void button2_Load(object sender, EventArgs e)
        {
            _logger.Trace("Secondbutton Load event execute!");
        }

        protected void button2_PreRender(object sender, EventArgs e)
        {
            _logger.Trace("Secondbutton PreRender event execute!");
        }

        protected void button2_Unload(object sender, EventArgs e)
        {
            _logger.Trace("Secondbutton Unload event execute!");
        } 
        #endregion
    }
}