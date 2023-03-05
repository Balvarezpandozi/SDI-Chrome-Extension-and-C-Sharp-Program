using Newtonsoft.Json.Linq;

public class NativeMessageManager
{
    //Sends message to chrome extension
    public void SendMessage(string outString)
    {
        string msgdata = outString;
        int DataLength = msgdata.Length;
        Stream stdout = Console.OpenStandardOutput();
        stdout.WriteByte((byte)((DataLength >> 0) & 0xFF));
        stdout.WriteByte((byte)((DataLength >> 8) & 0xFF));
        stdout.WriteByte((byte)((DataLength >> 16) & 0xFF));
        stdout.WriteByte((byte)((DataLength >> 24) & 0xFF));
        Console.Write(msgdata);
    }

    //Receives message from chrome extension
    public string ReceiveMessage()
    {
        Stream stdin = Console.OpenStandardInput();
        int length = 0;
        byte[] bytes = new byte[4];
        stdin.Read(bytes, 0, 4);
        length = System.BitConverter.ToInt32(bytes, 0);
        string input = "";
        for (int i = 0; i < length; i++)
        {
            input += (char)stdin.ReadByte();
        }
        JObject Read = Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(input);
        if (Read is null) throw new ArgumentNullException(); 
        return Read.ToString();

    }
}