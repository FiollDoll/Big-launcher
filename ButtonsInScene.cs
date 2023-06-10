using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Buttons
{
	public class ButtonsInScene
	{
		[XmlArray("Collection"), XmlArrayItem("Item")]
		public List<ButtonInfo> buttons { get; set;}

		public ButtonsInScene()
        {

        }
	}

	public class ButtonInfo
	{
		public int id;
		public string name;
		public string command;
		public string action;

		public bool optionHave;
		public bool otherOptionHave;
		public ButtonLocation position = new ButtonLocation();

		public ButtonInfo()
        {

        }

		public ButtonInfo(string nameButton)
        {
			name = nameButton;
        }

		public ButtonInfo(int idButton, string nameButton, string commandButton, string textButton, string actionButton, ButtonLocation pos, bool option = false, bool otherOptionsHave = false)
		{
			id = idButton;
			name = nameButton;
			command = commandButton;
			action = actionButton;
			position = pos;
			optionHave = option;
			otherOptionHave = otherOptionsHave;
		}
	}

	public class ButtonLocation
	{
		public int x, y, page;

		public ButtonLocation()
        {

        }

		public ButtonLocation(int pageButton, int posX, int posY)
        {
			x = posX;
			y = posY;
			page = pageButton;
        }
	}
}

