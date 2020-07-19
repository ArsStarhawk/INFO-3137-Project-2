/*
 * Author: James Kidd
 * Date: July, 19 - 2020
 * 
 */

using System;

namespace DocumentBuilderLibrary
{
    public class Director : IDirector
    {
        private IBuilder builder;

        public string _name { get; set; }
        public string _content { get; set; }

        public Director(string mode)
        {
            builder = mode.Equals("JSON") ? (IBuilder)new JBuilder() : new XBuilder();
        }

        public void BuildBranch()
        {
            builder.BuildBranch(_name);
        }

        public void BuildLeaf()
        {
            builder.BuildLeaf(_name, _content);
        }

        public void CloseBranch()
        {
            builder.CloseBranch();
        }

        public void Print()
        {
            Console.Write(builder.GetDocument().Print(0));
        }

    }
}