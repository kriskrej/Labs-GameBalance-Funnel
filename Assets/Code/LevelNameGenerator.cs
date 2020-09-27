using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public static class LevelNameGenerator {
    public static Queue<string> names = new Queue<string>();

    public static string PickRandom() {
        if (!names.Any())
            AddNamesToQueue();
        return names.Dequeue();
    }

    static void AddNamesToQueue() {
        var list =new List<string>{
            "riSKY daYdREaM", "A KiLLer", "SiLVEr LoVE", "rIsKY raInBOW", "BAByS RuNnER",
            "poison of tracK", "YeLlow Break", "hellisH FEELER", "a SaD rewRItE", "cOIn STar",
            "hIllS SEquel", "sPiRiT v2", "tHe painfUl StEp", "gamEPLaY tender", "A dOuble beat",
            "GODdEsS", "TrIvial wAVe", "RISky whiTe sqUARe", "wet nebulas", "tRue Passage",
            "MoNsTEr rEaliTy", "a flopper", "tricky AciD", "bIZArRE", "ThE smALL heavEnS",
            "blOod dinOsAURS", "MAN AnD gIRl", "SHamEfUL NigHTmare", "thinker"
        };
        names = new Queue<string>(list.OrderBy(o => new Guid()).Select(txt=>ToPascalCase(txt)));
    }

    static string ToPascalCase(string text) {
        var info = CultureInfo.CurrentCulture.TextInfo;
        return info.ToTitleCase(text.ToLower());
    }
}