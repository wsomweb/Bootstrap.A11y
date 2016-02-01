﻿// Affix.cs

// Copyright (C) 2013 Pedro Fernandes

// This program is free software; you can redistribute it and/or modify it under the terms of the GNU 
// General Public License as published by the Free Software Foundation; either version 2 of the 
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
// the GNU General Public License for more details. You should have received a copy of the GNU 
// General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 
// Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Web.UI;

namespace Tie.Controls.Bootstrap
{
    [ToolboxData("<{0}:Affix runat=server></{0}:Affix>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Panel))]
    [PersistChildren(false)]
    public class Affix : System.Web.UI.WebControls.Panel, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Affix"/> class.
        /// </summary>
        public Affix()
            : base()
        {
            this.OffsetTop = 100;
            this.OffsetBottom = 200;
        }

        /// <summary>
        /// Gets or sets the offset top.
        /// </summary>
        /// <value>
        /// The offset top.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(100)]
        public int OffsetTop
        {
            get { return (int)ViewState["OffsetTop"]; }
            set { ViewState["OffsetTop"] = value; }
        }

        /// <summary>
        /// Gets or sets the offset bottom.
        /// </summary>
        /// <value>
        /// The offset bottom.
        /// </value>
        [Category("Appearance")]
        [DefaultValue("")]
        public int OffsetBottom
        {
            get { return (int)ViewState["OffsetBottom"]; }
            set { ViewState["OffsetBottom"] = value; }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.CssClass);
            base.Render(writer);
        }

        /// <summary>
        /// Renders the HTML opening tag of the control to the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.AddAttribute("data-spy", "affix");
            writer.AddAttribute("data-offset-top", this.OffsetTop.ToString());
            writer.AddAttribute("data-offset-bottom", this.OffsetBottom.ToString());

            base.RenderBeginTag(writer);
        }

        /// <summary>
        /// Renders the HTML closing tag of the control into the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            base.RenderEndTag(writer);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(System.EventArgs e)
        {
            base.OnInit(e);
            base.CreateChildControls();
            base.ChildControlsCreated = true;
        }
    }
}
