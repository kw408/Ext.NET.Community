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

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class Parameter : BaseParameter
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public Parameter() { }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public Parameter(string name, string value) : base(name, value) { }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public Parameter(string name, string value, ParameterMode mode) : base(name, value, mode) { }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public Parameter(string name, string value, bool encode) : base(name, value, encode) { }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public Parameter(string name, string value, ParameterMode mode, bool encode) : base(name, value, mode, encode) { }
    }
}
