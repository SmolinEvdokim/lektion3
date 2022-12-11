// vid 1 - ne prinemaet ne vosvras4aet
void Method1()
{
    Console.WriteLine("Autor Smolin Evdokim");
}
Method1(); // tak visivaetsia etot vid funkzii obiazatelno ()


//vid 2 - tolko prinimaet argumenti
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Text.....");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
       Console.WriteLine(msg);
       i++; 
    }
}
//Method21("Text.....", 4);
//Method21(count: 4, msg: "neu Text");