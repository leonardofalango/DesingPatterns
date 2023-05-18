public class Facade
{
    // Facade is a class or function that does complex things in only one function

    private StreamReader st = new StreamReader("data.txt");
    private string line = string.Empty;
    private List<string> datas = new List<string>();
    private List<string> labels = new List<string>();
    public IEnumerable<string> GetData()
    {
        while (!st.EndOfStream)
        {
            //processing Data
            line = st.ReadLine() ?? "";

            if (!verifyLine(new char[]{'l', 'p', 'n', 'd'}, line))
                continue;

            line = line.ToLower();
            string[] lineSplit = line.Split("\"");
            labels.Add(lineSplit[0]);
            datas.Add(lineSplit[1]);
            
        }
        Func1();
        Func2();
        Func3();
        Func4();
        return datas;
    }

    private bool verifyLine(char[] chars, string line)
    {
        for (int i = 0; i < chars.Length; i++)
            if (chars[i] == line[0])
                return true;
        return false;
    }

    public void Func1() {   }

    public void Func2() {   }

    public void Func3() {   }

    public void Func4() {   }

}