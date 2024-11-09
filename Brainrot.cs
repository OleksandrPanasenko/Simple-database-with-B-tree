using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_B_tree
{
    internal class Brainrot
    {
        private static Random random = new Random();

        private static readonly string[] starters = { "Yo", "Bruh", "Omg", "Y'all", "Literally", "Fam", "Bet", "Slay", "No cap", "Sus", "Big mood", "I-" };
        private static readonly string[] subjects = { "main character energy", "vibes", "my aesthetic", "the drip", "the squad", "the fam", "bestie", "the fit", "the grindset", "my feed", "the tea", "my moodboard", "the playlist", "the cringe", "aesthetic goals", "the fomo", "this bop", "low-key feels", "this slay" };
        private static readonly string[] actions = { "hits different", "slays", "snaps", "gives", "goes hard", "serves", "low-key drips", "screams", "haunts", "vibes with", "spills the tea", "flexes", "shakes", "lives rent-free", "yeets", "bops", "catches feels", "haunts my mind" };
        private static readonly string[] adjectives = { "hard", "extra", "vibe-y", "low-key", "soft", "unhinged", "iconic", "savage", "legendary", "sus", "fire", "major cringe", "weird flex", "pure chaos", "deadass", "big yikes", "chaotic good", "next-level", "goated", "no cap" };
        private static readonly string[] fillers = { "like", "literally", "bruh", "srsly", "fr fr", "and", "tho", "ngl", "pls", "oml", "tbh", "rip", "y’all", "nope", "idk", "low-key", "rip", "bet", "aight", "sheeesh" };
        private static readonly string[] endings = { "not me tho", "that's a vibe", "tell me I'm wrong", "change my mind", "for real tho", "who dis?", "fr", "in my feels", "idk but same", "say less", "on god", "I can't", "that's facts", "rip", "deadass", "goated", "big mood", "that's the tea" };
        private static readonly string[] emojis = { "😭", "😳", "💀", "🤯", "🔥", "✨", "😩", "🖤", "🥺", "🤡", "👀", "🍃", "😈", "😔", "🙄", "💅", "🤦‍♀️", "🥴", "🤌", "😌" };

        public static string GenerateBrainrotString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(starters[random.Next(starters.Length)] + ", ");
            result.Append(subjects[random.Next(subjects.Length)] + " ");
            result.Append(actions[random.Next(actions.Length)] + " ");
            result.Append(adjectives[random.Next(adjectives.Length)] + ", ");
            result.Append(fillers[random.Next(fillers.Length)] + " ");
            result.Append(endings[random.Next(endings.Length)] + " ");
            result.Append(emojis[random.Next(emojis.Length)]);

            return result.ToString();
        }

    }
}
