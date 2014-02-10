using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public static class ENUMS
{
    //Character
    public enum SKILLS { Nahkampf, Hacken, Projektilwaffen, Handfeuerwaffen };
    public enum ATTRIBUTE { Stärke, Geschicklichkeit, Konstitution, Intelligenz, Charisma };
    public enum ENVIROMENT { Hunger, Durst, Müdigkeit, Tragkapazität };

    //ITEMS
    //public enum ITEMTYP { NahEinhand, NahZweihand, Brust, Beine, Füße, Kopf, Arme, Hände, Verbrauch, Quest, Undefined };


    public enum ITEMTYP { Ausrüstung, Verbrauch, Quest, Undefined };
    public enum ITEMSLOT { Einhand, Zweihand, Brust, Bein, Fuß, Kopf, Arm, Hand, Schulter, Undefined }

    public enum SCHADENSTYP { Physisch, Wasser, Feuer, Luft, Erde, Gift, Undefined };
}

