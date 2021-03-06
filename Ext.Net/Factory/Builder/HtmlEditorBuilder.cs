/********
 * This file is part of Ext.NET.
 *     
 * Ext.NET is free software: you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as 
 * published by the Free Software Foundation, either version 3 of the 
 * License, or (at your option) any later version.
 * 
 * Ext.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU AFFERO GENERAL PUBLIC LICENSE for more details.
 * 
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with Ext.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * @version   : 2.0.0 - Community Edition (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HtmlEditor
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Field.Builder<HtmlEditor, HtmlEditor.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new HtmlEditor()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HtmlEditor component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HtmlEditor.Config config) : base(new HtmlEditor(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(HtmlEditor component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The Text value to initialize this field with.
			/// </summary>
            public virtual HtmlEditor.Builder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of HtmlEditor.Builder</returns>
            public virtual HtmlEditor.Builder Listeners(Action<HtmlEditorListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as HtmlEditor.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of HtmlEditor.Builder</returns>
            public virtual HtmlEditor.Builder DirectEvents(Action<HtmlEditorDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as HtmlEditor.Builder;
            }
			 
 			/// <summary>
			/// An optional string or XTemplate configuration to insert in the field markup after the iframe element. If an XTemplate is used, the component's subTpl data serves as the context.
			/// </summary>
            public virtual HtmlEditor.Builder AfterIFrameTpl(XTemplate afterIFrameTpl)
            {
                this.ToComponent().AfterIFrameTpl = afterIFrameTpl;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// An optional string or XTemplate configuration to insert in the field markup after the textarea element. If an XTemplate is used, the component's subTpl data serves as the context.
			/// </summary>
            public virtual HtmlEditor.Builder AfterTextAreaTpl(XTemplate afterTextAreaTpl)
            {
                this.ToComponent().AfterTextAreaTpl = afterTextAreaTpl;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// An optional string or XTemplate configuration to insert in the field markup before the iframe element. If an XTemplate is used, the component's subTpl data serves as the context.
			/// </summary>
            public virtual HtmlEditor.Builder BeforeIFrameTpl(XTemplate beforeIFrameTpl)
            {
                this.ToComponent().BeforeIFrameTpl = beforeIFrameTpl;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// An optional string or XTemplate configuration to insert in the field markup before the textarea element. If an XTemplate is used, the component's subTpl data serves as the context.
			/// </summary>
            public virtual HtmlEditor.Builder BeforeTextAreaTpl(XTemplate beforeTextAreaTpl)
            {
                this.ToComponent().BeforeTextAreaTpl = beforeTextAreaTpl;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// The default text for the create link prompt.
			/// </summary>
            public virtual HtmlEditor.Builder CreateLinkText(string createLinkText)
            {
                this.ToComponent().CreateLinkText = createLinkText;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// The default font family (defaults to 'tahoma').
			/// </summary>
            public virtual HtmlEditor.Builder DefaultFont(string defaultFont)
            {
                this.ToComponent().DefaultFont = defaultFont;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// The default value for the create link prompt (defaults to http://).
			/// </summary>
            public virtual HtmlEditor.Builder DefaultLinkValue(string defaultLinkValue)
            {
                this.ToComponent().DefaultLinkValue = defaultLinkValue;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// A default value to be put into the editor to resolve focus issues (defaults to   (Non-breaking space) in Opera and IE6, ​ (Zero-width space) in all other browsers).
			/// </summary>
            public virtual HtmlEditor.Builder DefaultValue(string defaultValue)
            {
                this.ToComponent().DefaultValue = defaultValue;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// Enable the left, center, right alignment buttons (defaults to true).
			/// </summary>
            public virtual HtmlEditor.Builder EnableAlignments(bool enableAlignments)
            {
                this.ToComponent().EnableAlignments = enableAlignments;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// Enable the fore/highlight color buttons (defaults to true).
			/// </summary>
            public virtual HtmlEditor.Builder EnableColors(bool enableColors)
            {
                this.ToComponent().EnableColors = enableColors;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// Enable font selection. Not available in Safari. (defaults to true).
			/// </summary>
            public virtual HtmlEditor.Builder EnableFont(bool enableFont)
            {
                this.ToComponent().EnableFont = enableFont;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// Enable the increase/decrease font size buttons (defaults to true).
			/// </summary>
            public virtual HtmlEditor.Builder EnableFontSize(bool enableFontSize)
            {
                this.ToComponent().EnableFontSize = enableFontSize;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// Enable the bold, italic and underline buttons (defaults to true).
			/// </summary>
            public virtual HtmlEditor.Builder EnableFormat(bool enableFormat)
            {
                this.ToComponent().EnableFormat = enableFormat;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// Enable the create link button. Not available in Safari. (defaults to true).
			/// </summary>
            public virtual HtmlEditor.Builder EnableLinks(bool enableLinks)
            {
                this.ToComponent().EnableLinks = enableLinks;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// Enable the bullet and numbered list buttons. Not available in Safari. (defaults to true).
			/// </summary>
            public virtual HtmlEditor.Builder EnableLists(bool enableLists)
            {
                this.ToComponent().EnableLists = enableLists;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// Enable the switch to source edit button. Not available in Safari. (defaults to true).
			/// </summary>
            public virtual HtmlEditor.Builder EnableSourceEdit(bool enableSourceEdit)
            {
                this.ToComponent().EnableSourceEdit = enableSourceEdit;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual HtmlEditor.Builder EscapeValue(bool escapeValue)
            {
                this.ToComponent().EscapeValue = escapeValue;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// An array of available font families.
			/// </summary>
            public virtual HtmlEditor.Builder FontFamilies(string[] fontFamilies)
            {
                this.ToComponent().FontFamilies = fontFamilies;
                return this as HtmlEditor.Builder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of HtmlEditor.Builder</returns>
            public virtual HtmlEditor.Builder ButtonTips(Action<HtmlEditorButtonTips> action)
            {
                action(this.ToComponent().ButtonTips);
                return this as HtmlEditor.Builder;
            }
			 
 			/// <summary>
			/// An optional string or XTemplate configuration to insert in the field markup inside the iframe element (as attributes). If an XTemplate is used, the component's subTpl data serves as the context.
			/// </summary>
            public virtual HtmlEditor.Builder IframeAttrTpl(XTemplate iframeAttrTpl)
            {
                this.ToComponent().IframeAttrTpl = iframeAttrTpl;
                return this as HtmlEditor.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual HtmlEditor.Builder ExecCmd(string cmd, string value)
            {
                this.ToComponent().ExecCmd(cmd, value);
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual HtmlEditor.Builder ExecCmd(string cmd, bool value)
            {
                this.ToComponent().ExecCmd(cmd, value);
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual HtmlEditor.Builder InsertAtCursor(string text)
            {
                this.ToComponent().InsertAtCursor(text);
                return this;
            }
            
 			/// <summary>
			/// Protected method that will not generally be called directly. Pushes the value of the textarea into the iframe editor.
			/// </summary>
            public virtual HtmlEditor.Builder PushValue()
            {
                this.ToComponent().PushValue();
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual HtmlEditor.Builder RelayCmd(string cmd, string value)
            {
                this.ToComponent().RelayCmd(cmd, value);
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual HtmlEditor.Builder RelayCmd(string cmd, bool value)
            {
                this.ToComponent().RelayCmd(cmd, value);
                return this;
            }
            
 			/// <summary>
			/// Protected method that will not generally be called directly. Syncs the contents of the editor iframe with the textarea.
			/// </summary>
            public virtual HtmlEditor.Builder SyncValue()
            {
                this.ToComponent().SyncValue();
                return this;
            }
            
 			/// <summary>
			/// Toggles the editor between standard and source edit mode.
			/// </summary>
            public virtual HtmlEditor.Builder ToggleSourceEdit()
            {
                this.ToComponent().ToggleSourceEdit();
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual HtmlEditor.Builder ToggleSourceEdit(bool sourceEdit)
            {
                this.ToComponent().ToggleSourceEdit(sourceEdit);
                return this;
            }
            
 			/// <summary>
			/// Protected method that will not generally be called directly. It triggers a toolbar update by reading the markup state of the current selection in the editor.
			/// </summary>
            public virtual HtmlEditor.Builder UpdateToolbar()
            {
                this.ToComponent().UpdateToolbar();
                return this;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditor.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.HtmlEditor(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public HtmlEditor.Builder HtmlEditor()
        {
            return this.HtmlEditor(new HtmlEditor());
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditor.Builder HtmlEditor(HtmlEditor component)
        {
            return new HtmlEditor.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditor.Builder HtmlEditor(HtmlEditor.Config config)
        {
            return new HtmlEditor.Builder(new HtmlEditor(config));
        }
    }
}