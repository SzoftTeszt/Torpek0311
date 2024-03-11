// See https://aka.ms/new-console-template for more information
using TorpeAdatok.Data;
using TorpeAdatok.Models;

var _context = new Context();

if (!_context.KiHolDolgozott.Any()) {
    var sorok = File.ReadAllLines(@"c:\adat\kihol.csv").Skip(1);
    foreach (var s in sorok)
    {
        _context.KiHolDolgozott.Add(new KiHolDolgozott(s));
    }
    _context.SaveChanges();
}

foreach (var item in _context.KiHolDolgozott)
{
    Console.WriteLine(item);
}


