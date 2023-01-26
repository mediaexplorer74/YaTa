using System.Text;

namespace ru.yandex.taxi.map
{
	using Node = org.w3c.dom.Node;
	using NodeList = org.w3c.dom.NodeList;

	public class XMLhelper
	{
	  public static string getStringFromNode(Node paramNode)
	  {
		sbyte b1 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		if (paramNode.getNodeType() == 3)
		{
		  stringBuilder.Append(paramNode.getNodeValue());
		  return stringBuilder.ToString();
		}
		if (paramNode.getNodeType() != 9)
		{
		  StringBuilder stringBuffer = new StringBuilder();
		  for (sbyte b = 0; b < paramNode.getAttributes().getLength(); b++)
		  {
			stringBuffer.Append(" ").Append(paramNode.getAttributes().item(b).getNodeName()).Append("=\"").Append(paramNode.getAttributes().item(b).getNodeValue()).Append("\" ");
		  }
		  stringBuilder.Append("<").Append(paramNode.getNodeName()).Append(stringBuffer).Append(">");
		}
		else
		{
		  stringBuilder.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
		}
		NodeList nodeList = paramNode.getChildNodes();
		int i = nodeList.getLength();
		for (sbyte b2 = b1; b2 < i; b2++)
		{
		  stringBuilder.Append(getStringFromNode(nodeList.item(b2)));
		}
		if (paramNode.getNodeType() != 9)
		{
		  stringBuilder.Append("</").Append(paramNode.getNodeName()).Append(">");
		}
		return stringBuilder.ToString();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\map\XMLhelper.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}