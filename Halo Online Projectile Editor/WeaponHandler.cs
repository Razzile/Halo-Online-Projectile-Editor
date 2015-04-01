using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo_Online_Projectile_Editor
{
    public class WeaponHandler
    {
        public static uint[] projectiles =
        {
            0x001500, // Spiker 0                                   
            0x001509, // Beam Rifle 1                               
            0x00150C, // Hammer 2                                   
            0x00150E, // Plasma Turret 3                            
            0x00151E, // Assault Rifle (Defualt) 4                  
            0x001581, // Assault Rifle (Red) 5                      
            0x001582, // Assault Rifle (Yellow) 6                   
            0x001583, // Assault Rifle (Green) 7                    
            0x001584, // Assault Rifle (Gold) 8                     
            0x00157D, // Smg (Default) 9                            
            0x00158E, // Smg (Red) 10                               
            0x00158C, // Smg (Yellow) 11                            
            0x00158D, // Smg (Green) 12                             
            0x00158F, // Smg (Gold) 13                              
            0x00157C, // Battle Rifle (Default) 14                  
            0x001586, // Battle Rifle (Red) 15                      
            0x0015BB, // Battle Rifle (Yellow) 16                   
            0x0015BC, // Battle Rifle (Green) 17                    
            0x001585, // Battle Rifle (Blue) 18                     
            0x0015BD, // Battle Rifle (Purple) 19                   
            0x001587, // Battle Rifle (Gold) 20                     
            0x001580, // DMR (Default) 21                           
            0x00158A, // DMR (Red) 22                               
            0x001589, // DMR (Yellow) 23                            
            0x001588, // DMR (Green) 24                             
            0x0015BE, // DMR (Blue) 25                              
            0x0015BF, // DMR (Purple) 26                            
            0x00158B, // DMR (Gold) 27                              
            0x00157E, // Magnum (Default) 28                        
            0x001593, // Magnum (Red) 29                            
            0x001594, // Magnum (Gold) 30                           
            0x0014FE, // Carbine (Default) 31                       
            0x0015C3, // Carbine (Red) 32                           
            0x0015C0, // Carbine (Yellow) 33                        
            0x0015C4, // Carbine (Green) 34                         
            0x0015C1, // Carbine (Blue) 35                          
            0x0015C2, // Carbine (Purple) 36                        
            0x001591, // Carbine (Gold) 37                          
            0x001504, // Mauler (Default) 38                        
            0x001592, // Mauler (Gold) 39                           
            0x00159E, // Energy Sword 40                            
            0x00157F, // Energy Sword (No Charge) 41                
            0x001525, // Plasma Rifle (default) 42                  
            0x001590, // Plasma Rifle (gold) 43                     
            0x0014F7, // Plasma Pistol (default) 44                 
            0x001595, // Plasma Pistol (gold) 465                   
            0x0015A2, // Flag 46                                    
            0x0015A3, // Skull 47                                   
            0x0015A4, // Bomb 48                                    
            0x0015B1, // Sniper 49                                  
            0x0015B2, // Spartan Laser 50                           
            0x0015B3, // Rocker Launcher 51                         
            0x0014F8, // Needler 52                                 
            0x0014F9, // Fuel Rod 53                                
            0x0014FF, // Brute Shot 54                              
            00001585, // Shotgun 55                                 
            0x001A56, // Sentinel Beam 56                           
        };

        public static string[] list =
        {
            "Spiker", //[0]
            "Beam Rifle", //[1]
            "Hammer", //[2]
            "Plasma Turret", //[3]
            "Assault Rifle (Default)", //[4]
            "Assault Rifle (Red)", //[5]
            "Assault Rifle (Yellow)", //[6]
            "Assault Rifle (Green)", //[7]
            "Assault Rifle (Gold)", //[8]
            "Smg (Default)", //[9]
            "Smg (Red)", //[10]
            "Smg (Yellow)", //[11]
            "Smg (Green)", //[12]
            "Smg (Gold)", //[13]
            "Battle Rifle (Default)", //[14]
            "Battle Rifle (Red)", //[15]
            "Battle Rifle (Yellow)", //[16]
            "Battle Rifle (Green)", //[17]
            "Battle Rifle (Blue)", //[18]
            "Battle Rifle (Purple)", //[19]
            "Battle Rifle (Gold)", //[20]
            "DMR (Default)", //[21]
            "DMR (Red)", //[22]
            "DMR (Yellow)", //[23]
            "DMR (Green)", //[24]
            "DMR (Blue)", //[25]
            "DMR (Purple)", //[26]
            "DMR (Gold)", //[27]
            "Magnum (Default)", //[28]
            "Magnum (Red)", //[29]
            "Magnum (Gold)", //[30]
            "Carbine (Default)", //[31]
            "Carbine (Red)", //[32]
            "Carbine (Yellow)", //[33]
            "Carbine (Green)", //[34]
            "Carbine (Blue)", //[35]
            "Carbine (Purple)", //[36]
            "Carbine (Gold)", //[37]
            "Mauler (Default)", //[38]
            "Mauler (Gold)", //[39]
            "Energy Sword", //[40]
            "Energy Sword (No Charge)", //[41]
            "Plasma Rifle (default)", //[42]
            "Plasma Rifle (gold)", //[43]
            "Plasma Pistol (default)", //[44]
            "Plasma Pistol (gold)", //[45]
            "Flag", //[46]
            "Skull", //[47]
            "Bomb", //[48]
            "Sniper", //[49]
            "Spartan Laser", //[50]
            "Rocker Launcher", //[51]
            "Needler", //[52]
            "Fuel Rod", //[53]
            "Brute Shot", //[54]
            "Shotgun", //[55]
            "Sentinel Beam", //[56]
        };

        public static void SetNewProjectile(uint hex)
        {
            byte[] hexData = BitConverter.GetBytes(hex);

            byte[] rawData = new byte[6];

            hexData.CopyTo(rawData, 1);
            rawData[0] = 0xBA; // mov edx, {projectile}
            rawData[5] = 0x90; // nop
            // BA {projectile hex} 00 00 90
            MemoryManager.WriteToAddress(0xB5DBA5, rawData);
        }

    }
}
