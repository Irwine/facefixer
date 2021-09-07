using Mutagen.Bethesda;
using System.Threading.Tasks;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaceFixer
{
    public record Settings
    {
        [SettingName("Mods ciblés")]
        public List<ModKey> TargetMods = new List<ModKey>();
        
        [SettingName("Prioriser par l'ordre spécifié")]
        public bool PrioritizeBySpecifiedOrder = false;
        
        [SettingName("Attaque raciale")]
        public bool PatchAttackRace = true;
        
        [SettingName("Tenue par défaut")]
        public bool PatchDefaultOutfit = false;
        
        [SettingName("Morphologie du visage")]
        public bool PatchFaceMorph = true;
        
        [SettingName("Parties du visage")]
        public bool PatchFaceParts = true;
        
        [SettingName("Modèle distant")]
        public bool PatchFarAwayModel = true;
        
        [SettingName("Couleur des cheveux")]
        public bool PatchHairColor = true;
        
        [SettingName("Parties de la tête")]
        public bool PatchHeadParts = true;
        
        [SettingName("Textures de la tête")]
        public bool PatchHeadTexture = true;
        
        [SettingName("Taille")]
        public bool PatchHeight = true;
        
        [SettingName("Tenue de nuit")]
        public bool PatchSleepingOutfit = false;
        
        [SettingName("Luminosité des textures")]
        public bool PatchTextureLighting = true;
        
        [SettingName("Nuances")]
        public bool PatchTintLayers = true;
        
        [SettingName("Poids")]
        public bool PatchWeight = true;
        
        [SettingName("Armure portée")]
        public bool ArmurePortee = true;
    }
}
