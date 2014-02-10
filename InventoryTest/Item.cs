using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using UnityEngine;

using ITEMTYP = ENUMS.ITEMTYP;
using ITEMSLOT = ENUMS.ITEMSLOT;
using SCHADENSTYP = ENUMS.SCHADENSTYP;

public class Item
{
    //public Texture2D image;
    public int id;
    public String name;
    public float quality = 100.0f;

    public int quantity = 1;
    public float gewicht = 1.0f;
    public float gewichtGesamt = 1.0f;

    public float wert = 0.0f;
    public bool verkaufbar = true;


    public ITEMTYP typ = ITEMTYP.Undefined;
    public ITEMSLOT slot = ITEMSLOT.Undefined;

    


    //Waffe
    float angriffsgeschwindigkeit = 0.0f;
    float schaden = 0.0f;
    SCHADENSTYP schadensTyp = SCHADENSTYP.Undefined;

    public float wiederstandPhysisch = 0.0f;
    public float wiederstandFeuer = 0.0f;
    public float wiederstandWasser = 0.0f;
    public float wiederstandErde = 0.0f;
    public float wiederstandLuft = 0.0f;
    public float wiederstandGift = 0.0f;


    /// <summary>
    /// DummyItem
    /// </summary>

    public Item(int id, String name)
    {
        this.id = id;
        this.name = name;
    }

    /// <summary>
    /// Extended DummyItem
    /// </summary>

    public Item(int id, String name, float gewicht, ITEMSLOT slot, float wert, bool verkaufbar,float quality):this(id,name)
    {
        this.gewicht = this.gewichtGesamt = gewicht;
        this.slot = slot;
        this.wert = wert;
        this.verkaufbar = verkaufbar;
        this.quality = quality;
        
    }


    /// <summary>
    /// Waffe
    /// </summary>
    public Item(int id, String name, float gewicht, ITEMSLOT slot, float wert, bool verkaufbar, float quality, float angriffsgeschwindigkeit, float schaden, SCHADENSTYP schadensTyp)
        : this(id, name, gewicht, slot, wert, verkaufbar, quality)
    {
        this.angriffsgeschwindigkeit = angriffsgeschwindigkeit;
        this.schaden = schaden;
        this.schadensTyp = schadensTyp;

        //new Item(id, name, gewicht, ITEMTYP.Ausrüstung, slot, wert, true, angriffsgeschindigkeit, schaden, schadensTyp, 0, 0, 0, 0, 0, 0); }
    }
    /// <summary>
    /// Rüstung
    /// </summary>
    public Item(int id, String name, float gewicht, ITEMSLOT slot, float wert, bool verkaufbar, float quality, float wiederstandPhysisch, float wiederstandFeuer, float wiederstandWasser, float wiederstandErde, float wiederstandLuft, float wiederstandGift)
        : this(id, name, gewicht, slot, wert, verkaufbar, quality)
    {
        this.wiederstandPhysisch = wiederstandPhysisch;
        this.wiederstandFeuer = wiederstandFeuer;
        this.wiederstandWasser = wiederstandWasser;
        this.wiederstandErde = wiederstandErde;
        this.wiederstandLuft = wiederstandLuft;
        this.wiederstandGift = wiederstandGift;
        //new Item(id, name, gewicht, ITEMTYP.Ausrüstung, slot, wert, true, 0, 0, SCHADENSTYP.Undefined, wiederstandPhysisch, wiederstandFeuer, wiederstandWasser, wiederstandErde, wiederstandLuft, wiederstandGift); 
    }

    ///// <summary>
    ///// StandardItem
    ///// </summary>
    //public Item(int id, String name, float gewicht, ITEMTYP typ, ITEMSLOT slot, float wert, bool verkaufbar)
    //{ 

    ////    new Item(id, name, gewicht, typ, slot, wert, true, 0, 0, SCHADENSTYP.Undefined, 0, 0, 0, 0, 0, 0); 
    //}


    ///// <summary>
    ///// richtiger Konstruktor (Voll)
    ///// </summary>
    //public Item(
    //            int id,
    //            String name,
    //            float gewicht,
    //            ITEMTYP typ,
    //            ITEMSLOT slot,
    //            float wert,
    //            bool verkaufbar,
    //            float angriffsgeschwindigkeit,
    //            float schaden,
    //            SCHADENSTYP schadensTyp,
    //            float wiederstandPhysisch,
    //            float wiederstandFeuer,
    //            float wiederstandWasser,
    //            float wiederstandErde,
    //            float wiederstandLuft,
    //            float wiederstandGift)
    //{
    //    this.id = id;
    //    this.name = name;
    //    this.gewicht = gewicht;
    //    this.typ = typ;
    //    this.slot = slot;
    //    this.wert = wert;

    //    this.wiederstandPhysisch = wiederstandPhysisch;
    //    this.wiederstandFeuer = wiederstandFeuer;
    //    this.wiederstandWasser = wiederstandWasser;
    //    this.wiederstandErde = wiederstandErde;
    //    this.wiederstandLuft = wiederstandLuft;
    //    this.wiederstandGift = wiederstandGift;

    //}

}

