using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetMigrations.EF
{
    public class Initializer : CreateDatabaseIfNotExists<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            base.Seed(context);

            Genre punk = context.Genres.Add(new Genre() { Name = "Punk" });
            Genre blues = context.Genres.Add(new Genre() { Name = "Blues" });
            Genre techno = context.Genres.Add(new Genre() { Name = "Techno" });
            Genre hipHop = context.Genres.Add(new Genre() { Name = "Hip-Hop" });
            Genre jazz = context.Genres.Add(new Genre() { Name = "Jazz" });

            Genre pop = context.Genres.Add(new Genre() { Name = "Pop" });
            Genre reggae = context.Genres.Add(new Genre() { Name = "Reggae" });
            Genre rock = context.Genres.Add(new Genre() { Name = "Rock" });
            Genre alternativeRock = context.Genres.Add(new Genre() { Name = "Alternative rock" });
            Genre emoPop = context.Genres.Add(new Genre() { Name = "Emo pop" });
            context.SaveChanges();


            Category relax = context.Categories.Add(new Category() { Name = "Relax" });
            context.SaveChanges();



            Country gb = context.Countries.Add(new Country() { Name = "Great Britain" });
            Country usa = context.Countries.Add(new Country() { Name = "United States" });
            context.SaveChanges();

            Artist OliverTree = context.Artists.Add(new Artist() { CountryId = usa.Id, Name = "Oliver", Surname = "Nickell" });
            Artist CallMeKarizma = context.Artists.Add(new Artist() { CountryId = usa.Id, Name = "Morgan", Surname = "Parriott" });
            Artist BillieElish = context.Artists.Add(new Artist() { CountryId = gb.Id, Name = "Dominic", Surname = "Harrison" });
            context.SaveChanges();

            Song OTWasteMyTime = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 3, 27), Name = "Waste My Time", Rating = 3.8f, NumberOfPlays = 15 });
            Song OTLetMeDown = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 1, 51), Name = "Let Me Down", Rating = 4.8f, NumberOfPlays = 35 });
            Song OTCashMachine = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 2, 56), Name = "Cash Machine", Rating = 4.2f, NumberOfPlays = 15 });
            Song OTMiracleMan = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 2, 5), Name = "Miracle Man", Rating = 3.8f, NumberOfPlays = 20 });


            Song BEYouShouldSeeMeInACrown = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 3, 1), Name = "You should see me in a crown", Rating = 3.8f, NumberOfPlays = 25 });
            Song BECopycat = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 3, 39), Name = "Copycat", Rating = 4.3f, NumberOfPlays = 20 });
            Song BEBuryAFriend = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 3, 33), Name = "Bury a friend", Rating = 4.3f, NumberOfPlays = 10 });
            Song BEBadGuy = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 3, 26), Name = "Bad guy", Rating = 3.3f, NumberOfPlays = 30 });
            Song BEWhenThePartyOver = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 3, 14), Name = "When the party's over", Rating = 4.3f, NumberOfPlays = 10 });


            Song CMKWaste = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 2, 51), Name = "Waste", Rating = 4.2f, NumberOfPlays = 20});
            Song CMKGetMeOutOfLA = context.Songs.Add(new Song()
            {
                Duration = new System.TimeSpan(0, 3, 7),
                Name = "Get me out of L.A.", Rating=4, NumberOfPlays=10,
                Text =
"Sunset Boulevard again Pulling at my heart again But I came from a small town  where They do not care what car you're in But my friends in Hollywood drive a Mercedes And always do drugs and get wasted They buy out the store just to prove they got money for shoes But they can't pay their credit card statements Whoa(Oh oh) I think I'm losing all control (Oh oh) So(Oh oh) Get me out of L.A I'm going insane All of this fake shit I can't take another day Got to escape Trying to be famous But I hate who I've became I need a oneway tickеt Out of this dirty city Get me out of L.A Get mе out of L.A Fame is worse than heroin Look how it killed Marilyn Rest in peace bitch But I came from small town where You're family is therapy My friends in Melrose don't text me no more So I guess we're not friends anymore I've been hoping they write But my follower count ain't as high as they'd like So they show me the door I am sure Whoa(Oh oh) I think I'm losing all control (Oh oh) I don't know who I am no more I think it's time for me to go (Oh oh) So(Oh oh) Get me out of L.A I'm going insane All of this fake shit I can't take another day Got to escape Trying to be famous But I hate who I've became I need a oneway ticket Out of this dirty city Get me out of L.A Get me out of L.A Going on a trip to Hollywood Gonna have fun Tons of fun Going on a trip to Hollywood Gonna have fun Going on a trip to Hollywood Gonna have fun Tons of fun Going on a trip to Hollywood Gonna have fun Going on a trip to Hollywood Gonna have fun Tons of fun Going on a trip to Hollywood Gonna have fun Going on a trip to Hollywood Gonna have fun Tons of fun Going on a trip to Hollywood Gonna have fun"
            });
            Song CMKAmerica = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 2, 39), Name = "America",Rating=4.8f, NumberOfPlays=25, Text= "I went to college now I'm brokeTook out a million dollar loanBut I'll be fineWhere do I sign?No fucking wonder I'm aloneMy only friends are on my phoneAnd my shit diedOh well, I triedStress is building up inside of everyoneBlame my parents but their parents didn't get it doneI'm in debt so my life's over and I'm twenty-oneAre you having fun?Are you having fun?In America you can go and be what you likeDream of miracles but we don't believе in a godFind out who you areWhatever's on thе T.V. tonightWe buy itWe buy itIn America guns are going off in the streetsIt's a right so it's alright unless they're shooting at meNine to five until ya die is what it costs to be freeWelcome to the land of opportunityIn AmericaI'm feeling down prescribe a drugI'm swiping right to fall in loveAnd I'll be fineIt's just the timesDid I mention?They have us go to college just to make us alcoholicsWhile they fill our brains with bullshitAs they're emptying our walletsAct like prophets just to make a profitThey must think I'm stupidI ain't gonna fucking listen I don't wanna face the musicThese politics and racists only wanna just abuse usUse their power to enslave usLeaving normal people uselessI'm sick of being chainedIt's time to rise up and refuse itBut it'll have to be tomorrow 'cuz tonight I'm at the moviesIn America you can go and be what you likeDream of miracles but we don't believe in a godFind out who you areWhatever's on the T.V. tonightWe buy itWe buy itIn America guns are going off in the streetsIt's a right so it's alright unless they're shooting at meNine to five until ya die is what it costs to be freeWelcome to the land of opportunityIn AmericaStress is building up inside of everyoneBlame my parents but their parents didn't get it doneI'm in debt so my life's over and I'm twenty-oneAre you having fun?Are you having fun?In America" });
            Song CMKRedRoses = context.Songs.Add(new Song() { Duration = new System.TimeSpan(0, 2, 50), Name = "Red Roses",Rating=5,NumberOfPlays=40,Text= "No surprise, hate in your eyesFull of rage but empty insideLet's decide, it's you or IBut at least you're alive tonightTeeth are grounded, I don't mind itLove the violenceLost my mind and I can't find itSit in silence (Silence)Fuck that screaming, it's like I beat itHear the voices, I can't leave 'emEmbrace the pain and fight the demonsI'm in pieces, all I see isA little bit of red, a little bit of red rosesDripping from my handsCut 'em both of them openWay too many lives, way too many bonds brokenWay too many bonds brokenNo surprise, hate in your eyes Full of rage but empty insideLet's decide, it's you or IBut at least you're alive tonight, yeahAt least you're alive tonightAt least you're alive tonight Bones are breaking, ground is shakingHeart is racingMuch temptation, burn the nationGod can't save us (God can't save us)Fuck that screaming, it's like I beat itLet these voices off their leashesEmbrace the pain and fight the demonsCan't find peace when all I see isA little bit of red, a little bit of red rosesDripping from my handsCut 'em both of them openWay too many lives, way too many bonds brokenWay too many bonds brokenNo surprise, hate in your eyesFull of rage but empty insideLet's decide, it's you or IBut at least you're alive tonight, yeahAt least you're alive tonightAt least you're alive tonightAt least you're alive tonightA little bit of red, a little bit of red rosesTripping from my hands Cut 'em both of them openWay too many lives, way too many bonds brokenWay too many bonds broken" });
            context.SaveChanges();



            Album albumCMK = context.Albums.Add(new Album() { Name = "To Hell With Hollywood", GenreId = alternativeRock.Id, Year = 2020, ArtistId = CallMeKarizma.Id, Rating = 4.7f });

            albumCMK.Songs.Add(CMKRedRoses);
            albumCMK.Songs.Add(CMKAmerica);
            albumCMK.Songs.Add(CMKWaste);
            albumCMK.Songs.Add(CMKGetMeOutOfLA);
            context.Albums.Add(albumCMK);
            context.SaveChanges();



            Album albumOT = context.Albums.Add(new Album() { Name = "Ugly is Beautiful", GenreId = alternativeRock.Id, Year = 2020, ArtistId = OliverTree.Id ,Rating=4.2f});
            albumOT.Songs.Add(OTCashMachine);
            albumOT.Songs.Add(OTLetMeDown);
            albumOT.Songs.Add(OTMiracleMan);
            albumOT.Songs.Add(OTWasteMyTime);
            context.Albums.Add(albumOT);
            context.SaveChanges();



            Playlist playlist = context.Playlists.Add(new Playlist() { CategoryId = relax.Id, Name = "Chill music" });
            playlist.Songs.Add(BEBadGuy);
            playlist.Songs.Add(BEBuryAFriend);
            playlist.Songs.Add(BECopycat);
            playlist.Songs.Add(BEWhenThePartyOver);
            playlist.Songs.Add(BEYouShouldSeeMeInACrown);

            context.SaveChanges();


        }
    }
}
