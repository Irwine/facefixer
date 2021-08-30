using Mutagen.Bethesda;
using System;
using System.Collections.Generic;
using System.Text;
using Mutagen.Bethesda.Plugins;
namespace FaceFixer
{
    public record Settings
    {
        public List<ModKey> ModsCibles = new List<ModKey>();
        public bool PrioriseParLOrdreSpecifie = false;
        public bool AttaqueRaciale = true;
        public bool TenueParDefaut = false;
        public bool MorphologieDuVisage = true;
        public bool PartiesDuVisage = true;
        public bool ModeleDistant = true;
        public bool CouleurDeCheveux = true;
        public bool PartiesDeLaTete = true;
        public bool TextureDeLeTete = true;
        public bool Taille = true;
        public bool TenueDeNuit = false;
        public bool EclairageTexture = true;
        public bool Couches = true;
        public bool Poids = true;
        public bool ArmurePortee = true;
    }
}
