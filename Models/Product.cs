using System;
using System.Runtime.InteropServices;

namespace uppfinnaren_1_0_maxie1337.Models;

public class Product
{
    // Namn, beskrivning och en url på bilden som ska visas vid produkten
    public string Name {get; set;} = string.Empty;
    public int ProductId {get; set;}
    public string Description {get; set;} = string.Empty;
    public string ImgUrl {get; set;} = string.Empty;
    public string Category {get; set;} = string.Empty;
    
}
