using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfBez_group4
{
    class Crypt
    {
        public Crypt()
        {

        }

        public Crypt(string encrypt, char decrypt)
        {
            this.encrypt = encrypt;  //зашифр
            this.decrypt = decrypt;  //расшифр
        }

        private string encrypt;
        public string Encrypt
        {
            get { return encrypt; }
        }

        private char decrypt;
        public char Decrypt
        {
            get { return decrypt; }
        }
    }

    class Position
    {
        private int first;
        public int First
        {
            get { return first; }
        }

        private int second;
        public int Second
        {
            get { return second; }
        }

        private int place;
        public int Place
        {
            get { return place; }
        }

        public Position(int first, int second, int place)
        {
            this.first = first;
            this.second = second;
            this.place = place;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str = "HAAJBCFDPFPOGCKNNONANMKHMEOEHBANEKKNFAJPCFBHHPAMDAJAFNMIMBHEDEACHFMPLAGLAAHACJCBHKICBMHFOHFNOCHDDAJOGGBAOHPODFINAMCOOPBMFHANBFIOJAAHDNKILBAAOMFNDNOLOPDAOBPIHCDPFDHKAMGEMKGENKINKKICOEEAHKIFDMHDKAAIGKKMHLIHOBEKMKIDBBFAMFECEGPBKHHAMHNJKHCIDEAFAOIFHBBBABJAOFGKJAANECNACCADEKAKDAAJCIGDNCHOACAGMAANLDBGAHELMAGAKMECIHMKOAINFOHJAFMHFEJFMJAELKFMNNAFGDMHABOJJIGHMHFKCMKCFPEMGCILMKCAFDBCNACAAKAPHOIFIBEKACFAGKGMOEOFBKBMDLIPPAMMCFCANJNMCPHCHBAHAFANKBHFNOAAIOAFONAAEMBMHPIHODJDNNAMIJBHAIAJLMCBANOAKCOPKPJICBABDCHFKLJPKPPIPLGDEAJFPJHFNFBAMDNGJCDAJKEGOCAFMMADFLAJABDMAHGAJLALAFGOJOGFEBAJJMONKFGKNCBHKKKIHFCJOAAFFJGPDMODNDMMADPDIDOAAPJABKDNNAAMDLDNFKAAICEAONAFBNPFDNIEIAGAHMHDAMDPAEFAPCPCICHAJGMINEEACIAODAJKIALLAADAAFIAOAANPEEGHBIDIGGBANAABIPNAFAJIAJMNAAOMDLBABAJOGICOKICCEMHOMINLFKHFOIDOFPMMANCDBPLBHFANBANAAKAFBAJANOABFLEDCAHNGAKCFGKBBAJAHHAPAIPNAANILCPBPAPFEGCAMCNGJCFNCAGJDABEKIDGLFJFMBGEGCJPNOAPHCPADOALMAOMAAFBBDFOAENEHBJCNANPEILKJHKIJOEOAAEIAFOOCNONGBKDCHNHCKINHHAEHAFCAAOMMKBKCHKKNILAFGONLBFNJJAHPIACNOMDECNOIKIBPCCNOIABPEDAAAAABAIOMEDMNHBCOIHGJHDMNANHHBBAACJDMODAOINCKBICOAKHBOBMKIHJIMJIOCEMHFIAAANFGBMMGACLCOBMMEMNLJJHDEFHACHONACDBKPABIAPMHMIAGALJFILMEDBKAGMNAAMEBMDCEHPBAJNOICLBGFNEAOJDHNKMCADPCINEIOOPJACAAIIMIJNIHAHFEDAOIDHLMJODAIOAHIDAAMAHDGJNDPGJCCCAANLJNIHAHHOAABOONKIBCHHBIFJCIEOMEBJNAEAPIJOHNPMAAMJGMDHFEFEPECCDHCAFIFNHKAIKHGKNAFAGNJAKKAENGIADPFHIIHKBAIFAMGNMCKMPFDFMAGKFIHDKIAOIHCHLPFJJJDEAJMIMCDKPJIJEEHHAJAOMBHNKHAJFAKMEBCIHLDBMENGOHAMAJANLJAFKEMBKJPOKKAEHKAKMIIJAAAIHFAONIOAEHAONABAKIFBDDCDCAHOAGJKNACBJIPIPIEAAHDHMEAODCEABHAIAJMKKICKGFMOGINPKHGDBNDJFEONMPABAPDNMCOHBMFFGGNNMIBNJKAIPCOAMOABBAHOAJKCCGHPFOCMHIENONACLBNMMOEHBAPEKKNIDNMCLBHJOABANOAPLKCKHJIFAACNCHFOBKMAOAJFMGFHFGMAELKOMHOKLCKOMEDOABNACIJNIPPOAAMDDGODEIDFEEICDPFGGNGMNHEGCGBMHFKOPOGPHECLMIKFAAHFLIIKKMKEAFBKKIDIFOBAAIAAMPKAFGMCMBJNIJALPCDMHFKJLJBDKEPJAIHAKIACOPMNCAGLKJONFGOHCLECIAHPMKIOMEBIJHBAMIJKLNHMAAJKLMFADEJJOPONMEDPDGGPEOCPDHGADDKGCHKKCAIMIIKFKINLIILABGJDJOJMAJCECCPNFCAFPHIDOOFNEHHHPPHJFGKEAJMJIMLOFBIDBEDGHFAFEBMAKPAINAAAONCNJCJMPJEDKHDANAAKDNDCAAKAHJIMKIHJAAFIBCEIAFJONANACIJDHIHLNOOHFAADIDMNEHAOMAGFONNJIBFAEMJKCAAKAACBEFDMJICKCKGOFAJNJKOADIJEGPNAKINPHKJHMAFPGOGKAAHKIBMKMIKHFFDKFNDPBHBENIOGPPPFAAICEMJMAGCLMEOAHHMNKDMMNJEBKEDHAAOPGJBMEHCCGIEKMCKBMCJKFKIKFIBKFGMNDHAHMIFJNCFKNAHCKAMDBIPFCFPKHHAGLEKCGIHLGAOBKIOFGEDDNNPHONBMHFNOGICEHEONPADAMCMOMHCENABIJEFMAAHEOJOOEENIOFACNANPNDIKBHKGGOHKAAMDPCDDBIHLEEAMAJDCGJFKCEIGFEEMAJAAJBPNCCAMNAMDOOFJIPMHCPHDCGOMAJMBPEIOAEIMBEMDPOAHCJELPDDNJAEAAAKHGGMOHAICFIBKLDAAOMODNIDFLGFCAHAHIAHNLHOMMAEMOINAPLGAPCJNCAAAOINJAFDCKAKFDOMACHCCDAIKPJICFCFAKIFFDDJHLAFDHGENAAHMHJPCDAHNPFACNODHGHANBKAJCHBONHAGPCBOJNOBHAOEHHNMKHAMNOEBIAGKMCFDAKANDIOGJGIHAAICICMKFHIHCEKPCHMEFMNNHCAFMECMOIOCHONAILAGKIEENOKFHEFFHBGOOIIACHKJLFDFFANEFKEBOFCKAFABDKKANDLCHMAEHKIANCAOIALNHFMCDAKCDAHEKEOCFNDHEFCAPDADCPLABKOOBJDHMAPPIFPNNGDJFBHCOGEPMDNKALAMCMKKHCIMGALKOIFNEEAAKIAJKGJHAJOIGCFKBFIBMNAMMECGABADKEHOGHOAAJAKBMDKFAICCJLCAAMFBFKGAHPGACAAMEOHBIAAIJJPBNGINOMBLCAKKEIDNCMMKIAHCPGHFEHPJAMONACCBFJPCICODHOAIEMKIPEANJAJJEEDKCNAOCMNNPAJJANAMCOPFDOFHANIGIFAKIKHKFPODAILFKINNAFGLFAAKHAPEAMHONOJBFCNCHAIMOGNEOMAGBIFGGGGKEDMAHAKCIBBFENANAMAPOAFCPFFIABGDAONMEOOHMDNCAOLBNHACHKLOMBEPABDAKIMKIMLMMHHJEFHFCIOMCFGEACNFIOBHGFKAAMLJFMHAIFBPENNMCILDHFNIAOLDEFCHFABIDLACHADNAKAIENCECMKPJIHLABMAAMAJIDHPEFJJEOCDDAOECKMKHEKPJAINOMKEOMKMEIINCOKMCADOMJFCIGEJAPFOIDCPLKPPMCNCPDCKIAHNLKNNHONDADDBNODFBEOCPIDCOJLAAOCNMDCKADHDIFFLDLJCGCFIMGDPABAEBMOMMBKHJCCECOHJPOBIMAAMFABHOHMNACNGPNBKENBKHDJNOMLOHKOBPONMCPODDAGMHKCEOHEEAPCHHHBKNPOFHIMHHNOHFKHBMENAOOOPIHDAAEHDBNOCPNFIJJMAAEPICCOEENBABINDPKLNMBKEOIBFKBHCHOPCCAKLFINJIBEAJNMEDOODBIFNAAFNOALMFJKJGIDGALICHKIBKIKNEIJOIADNOAKDIIKDHIMBAEKAJNIHFEONINDLABONAHKOBNAPIJAFFAMAAMDFPJHAEFLMENCDHCDGJMNFKAOIHAANAFCPKDABJAKFGADKCNCPGHNDPAHFABFAAKPHBLMDGCDPIEHDDEEHHAOMFIJPBHAFGNNJBNFMANFBAAFOIMKGKFDGMPBFCNAAAECLDJHHAFOLJGAKIFKGMKDGAHGBGHDOIKHPIJMEPCABCCKAAMKIBLMGICKKEJAONMIHDNONJIICEEEAJMIMEDOEBIHNEINAAEENMCABAJLMJHOKICHOEEOBINDCKMMEOHMCFGOKEIIEFAHEBMOJKAAIFABFCMKMEAFBOEDNIDPHAFFCHAKPMFMBAELKAPMCHMBMFHHPEFKCEODAANMEHMHKHLDPGJKAJMGJHDABIJLBECOIHAGKKEFJIGFBAIMAACGGKNCHEHKNKMHMEFKGDFCHFHLOAGOHFKIAPCAAIAKOIJAAJABCKGMFAELEAIFHFCDEDNNKGAFCKPADPNKCMBKPAIHJAFDOIDPDPKFEPGIPDDHCHMBOGBKBFIKFEGANAPFAMKDDAHCCCFADPOMDOEECABMFNNOCHHBFPNKKNIBAHLMDPKAKGBBOENAPIGAOIAEJAHEEABFBJJFNAAGHAMMIGCCKJPMHHOEJFBDMEPJKOIAOIAGPPDEMABLGJHCAAHIBFKGMHPLCFGAMEOHLFNAJJJHBNAMCKNBEHFNIBGKBAHMMBMNEDLMCBBCBBG";

            int count = 0;
            List<string> arr = new List<string>();

            while (str.Length / 32 > count)
            {
                arr.Add(string.Empty);
                for (int i = 0; i < 32; i++)
                {
                    arr[count] += str[i + (count * 32)];
                }
                count++;
            }

            List<Crypt> alphabet = new List<Crypt>();
            alphabet.Add(new Crypt("NA", 'а'));
            alphabet.Add(new Crypt("GP", 'А'));
            alphabet.Add(new Crypt("HF", 'в'));
            alphabet.Add(new Crypt("MC", 'с'));
            alphabet.Add(new Crypt("NO", 'к'));
            alphabet.Add(new Crypt("JK", 'К'));
            alphabet.Add(new Crypt("KI", 'о'));
            alphabet.Add(new Crypt("OK", 'О'));
            alphabet.Add(new Crypt("AA", ' '));
            alphabet.Add(new Crypt("IE", 'й'));
            alphabet.Add(new Crypt("MB", '*'));
            alphabet.Add(new Crypt("AP", 'н'));
            alphabet.Add(new Crypt("ME", 'е'));
            alphabet.Add(new Crypt("CH", 'р'));
            alphabet.Add(new Crypt("AJ", 'н'));
            alphabet.Add(new Crypt("FA", 'з'));
            alphabet.Add(new Crypt("DD", 'г'));
            alphabet.Add(new Crypt("BN", 'ж'));
            alphabet.Add(new Crypt("AH", 'У'));
            alphabet.Add(new Crypt("OO", 'у'));
            alphabet.Add(new Crypt("OI", 'и'));
            alphabet.Add(new Crypt("HL", 'И'));
            alphabet.Add(new Crypt("ON", 'д'));
            alphabet.Add(new Crypt("HD", 'Д'));
            alphabet.Add(new Crypt("DP", 'л'));
            alphabet.Add(new Crypt("EB", 'я'));
            alphabet.Add(new Crypt("HH", 'п'));
            alphabet.Add(new Crypt("AL", 'П'));
            alphabet.Add(new Crypt("FG", 'т'));
            alphabet.Add(new Crypt("FN", 'ь'));
            alphabet.Add(new Crypt("EO", 'ш'));
            alphabet.Add(new Crypt("CK", 'х'));
            alphabet.Add(new Crypt("DC", 'Х'));
            alphabet.Add(new Crypt("DH", 'м'));
            alphabet.Add(new Crypt("BP", 'М'));
            alphabet.Add(new Crypt("PC", 'ц'));
            alphabet.Add(new Crypt("IH", 'э'));
            alphabet.Add(new Crypt("KC", 'ч'));
            alphabet.Add(new Crypt("KK", 'б'));
            alphabet.Add(new Crypt("NH", 'Б'));
            alphabet.Add(new Crypt("JP", 'ю'));
            alphabet.Add(new Crypt("FM", 'ы'));
            alphabet.Add(new Crypt("CC", 'ф'));
            alphabet.Add(new Crypt("DE", 'щ'));

            alphabet.Add(new Crypt("EJ", ','));
            alphabet.Add(new Crypt("NG", '.'));
            alphabet.Add(new Crypt("GE", '-'));
            alphabet.Add(new Crypt("LD", '-'));
            alphabet.Add(new Crypt("HM", '-'));
            alphabet.Add(new Crypt("CE", ')'));
            alphabet.Add(new Crypt("ML", '('));
            alphabet.Add(new Crypt("FC", '<'));
            alphabet.Add(new Crypt("MH", '>'));

            alphabet.Add(new Crypt("PO", '2'));
            alphabet.Add(new Crypt("LA", '8'));
            alphabet.Add(new Crypt("BK", '4'));
            alphabet.Add(new Crypt("HP", '5'));
            alphabet.Add(new Crypt("CD", '1'));
            alphabet.Add(new Crypt("OF", '9'));
            alphabet.Add(new Crypt("JA", '0'));
            alphabet.Add(new Crypt("AG", '3'));
            alphabet.Add(new Crypt("FB", '7'));
            

            List<Position> positions = new List<Position>();
            positions.Add(new Position(3, 14, 0));
            positions.Add(new Position(8, 11, 2));
            positions.Add(new Position(1, 2, 1));
            positions.Add(new Position(17, 18, 5));
            positions.Add(new Position(19, 30, 4));
            positions.Add(new Position(0, 10, 3));
            positions.Add(new Position(16, 26, 7));
            positions.Add(new Position(24, 27, 6));

            string result = string.Empty;
            foreach (var item in arr)
            {
                bool go = false;
                string decrypted = "*";
                decrypted = decrypted.PadRight(8, '*');
                StringBuilder sb = new StringBuilder(decrypted);

                foreach (var letter in alphabet)
                {
                    foreach (var pos in positions)
                    {
                        if (item[pos.First] == letter.Encrypt[0] && item[pos.Second] == letter.Encrypt[1])
                        {
                            sb[pos.Place] = letter.Decrypt;
                            go = true;
                        }
                    }
                }

                //if(go)
                //{
                //    Console.WriteLine(item);
                //    Console.WriteLine(sb);
                //}

                result += sb;
            }

            Console.WriteLine(result);

            Console.ReadKey(true);
        }
    }
}
