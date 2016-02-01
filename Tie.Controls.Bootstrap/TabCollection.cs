// TabCollection.cs

// Copyright (C) 2013 Pedro Fernandes

// This program is free software; you can redistribute it and/or modify it under the terms of the GNU 
// General Public License as published by the Free Software Foundation; either version 2 of the 
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
// the GNU General Public License for more details. You should have received a copy of the GNU 
// General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 
// Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System.Collections;
using System.Web.UI;

namespace Tie.Controls.Bootstrap
{
    public class TabCollection : CollectionBase
    {
       
        protected Control Parent = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TabCollection" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public TabCollection(Control parent)
        {
            Parent = parent;
        }

        /// <summary>
        /// Indexer property for the collection that returns and sets an item
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public TabPage this[int index]
        {
            get { return (TabPage)List[index]; }
            set { List[index] = value; }
        }

        /// <summary>
        /// Adds the specified tab.
        /// </summary>
        /// <param name="Tab">The tab.</param>
        public void Add(TabPage Tab)
        {
            List.Add(Tab);
            Parent.Controls.Add(Tab);
        }

        /// <summary>
        /// Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="item">The item.</param>
        public void Insert(int index, TabPage item)
        {
            List.Insert(index, item);
        }

        /// <summary>
        /// Removes the specified tab.
        /// </summary>
        /// <param name="Tab">The tab.</param>
        public void Remove(TabPage Tab)
        {
            List.Remove(Tab);
        }

        /// <summary>
        /// Determines whether [contains] [the specified tab].
        /// </summary>
        /// <param name="Tab">The tab.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified tab]; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(TabPage Tab)
        {
            return List.Contains(Tab);
        }

        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public int IndexOf(TabPage item)
        {
            return List.IndexOf(item);
        }

        /// <summary>
        /// Copies to.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="index">The index.</param>
        public void CopyTo(TabPage[] array, int index)
        {
            List.CopyTo(array, index);
        }
    }
}
