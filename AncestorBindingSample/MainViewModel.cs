using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AncestorBindingSample;


public class MainViewModel : ObservableObject
{
    private string _someText = "Lorem Ipsum";

    public string SomeText
    {
        get => _someText;
        set => SetProperty(ref _someText, value);
    }

    private int[] _items = [1, 2, 3, 4, 5];
    public int[] Items
    {
        get => _items;
        set => SetProperty(ref _items, value);
    }
}
