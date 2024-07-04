namespace Poema {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("site utilizado como referência:https://www.pensador.com/poemas_mais_lindos_da_literatura_brasileira/");

            while (true) {
                try {

                    Console.Write("Digite um número inteiro de 1 até 10 para ler um poema (ou qualquer outro número para sair): ");

                    int num = int.Parse(Console.ReadLine());

                    if (num < 1 || num > 10) {
                        Console.WriteLine("Número fora do intervalo de 1 a 10. Saindo...");
                        break;
                    }

                    switch (num) {
                        case 1:
                            Console.WriteLine("Você digitou 1");
                            Console.WriteLine("Soneto de Fidelidade (Vinicius de Moraes)\r\n\nDe tudo, ao meu amor serei atento\r\nAntes, e com tal zelo, e sempre, e tanto\r\nQue mesmo em face do maior encanto\r\nDele se encante mais meu pensamento.Quero vivê-lo em cada vão momento\r\nE em louvor hei de espalhar meu canto\r\nE rir meu riso e derramar meu pranto\r\nAo seu pesar ou seu contentamento.E assim, quando mais tarde me procure\r\nQuem sabe a morte, angústia de quem vive\r\nQuem sabe a solidão, fim de quem amaEu possa me dizer do amor (que tive):\r\nQue não seja imortal, posto que é chama\r\nMas que seja infinito enquanto dure.\n");
                            break;
                        case 2:
                            Console.WriteLine("Ora direis ouvir estrelas (Olavo Bilac)\r\n\nOra (direis) ouvir estrelas! Certo\r\nPerdeste o senso!” E eu vos direi, no entanto,\r\nQue, para ouvi-las, muita vez desperto\r\nE abro as janelas, pálido de espanto…E conversamos toda a noite, enquanto\r\nA Via Láctea, como um pálio aberto,\r\nCintila. E, ao vir do sol, saudoso e em pranto,\r\nInda as procuro pelo céu deserto.Direis agora: “Tresloucado amigo!\r\nQue conversas com elas? Que sentido\r\nTem o que dizem, quando estão contigo?”E eu vos direi: “Amai para entendê-las!\r\nPois só quem ama pode ter ouvido\r\nCapaz de ouvir e de entender estrelas.”\n");
                            break;
                        case 3:
                            Console.WriteLine("Canção do Exílio (Gonçalves Dias)\r\n\nMinha terra tem palmeiras,\r\nOnde canta o Sabiá;\r\nAs aves, que aqui gorjeiam,\r\nNão gorjeiam como lá.Nosso céu tem mais estrelas,\r\nNossas várzeas têm mais flores,\r\nNossos bosques têm mais vida,\r\nNossa vida mais amores.Em cismar, sozinho, à noite,\r\nMais prazer encontro eu lá;\r\nMinha terra tem palmeiras,\r\nOnde canta o Sabiá.Minha terra tem primores,\r\nQue tais não encontro eu cá;\r\nEm cismar — sozinho, à noite —\r\nMais prazer encontro eu lá;\r\nMinha terra tem palmeiras,\r\nOnde canta o Sabiá.Não permita Deus que eu morra,\r\nSem que eu volte para lá;\r\nSem que desfrute os primores\r\nQue não encontro por cá;\r\nSem qu’inda aviste as palmeiras,\r\nOnde canta o Sabiá.\n");
                            break;
                        case 4:
                            Console.WriteLine("José (Carlos Drummond de Andrade)\r\n\nE agora, José?\r\nA festa acabou,\r\na luz apagou,\r\no povo sumiu,\r\na noite esfriou,\r\ne agora, José?\r\ne agora, você?\r\nvocê que é sem nome,\r\nque zomba dos outros,\r\nvocê que faz versos,\r\nque ama, protesta?\r\ne agora, José?Está sem mulher,\r\nestá sem discurso,\r\nestá sem carinho,\r\njá não pode beber,\r\njá não pode fumar,\r\ncuspir já não pode,\r\na noite esfriou,\r\no dia não veio,\r\no bonde não veio,\r\no riso não veio,\r\nnão veio a utopia\r\ne tudo acabou\r\ne tudo fugiu\r\ne tudo mofou,\r\ne agora, José?E agora, José?\r\nsua doce palavra,\r\nseu instante de febre,\r\nsua gula e jejum,\r\nsua biblioteca,\r\nsua lavra de ouro,\r\nseu terno de vidro,\r\nsua incoerência,\r\nseu ódio, – e agora?Com a chave na mão\r\nquer abrir a porta,\r\nnão existe porta;\r\nquer morrer no mar,\r\nmas o mar secou;\r\nquer ir para Minas,\r\nMinas não há mais.\r\nJosé, e agora?\r\n\r\nSe você gritasse,\r\nse você gemesse,\r\nse você tocasse,\r\na valsa vienense,\r\nse você dormisse,\r\nse você cansasse,\r\nse você morresse...\r\nMas você não morre,\r\nvocê é duro, José!\r\n\r\nSozinho no escuro\r\nqual bicho-do-mato,\r\nsem teogonia,\r\nsem parede nua\r\npara se encostar,\r\nsem cavalo preto\r\nque fuja a galope,\r\nvocê marcha, José!\r\nJosé, para onde?\n");
                            break;
                        case 5:
                            Console.WriteLine("Amor (Álvares de Azevedo)\r\n\nAmemos! Quero de amor\r\nViver no teu coração!\r\nSofrer e amar essa dor\r\nQue desmaia de paixão!Na tu’alma, em teus encantos\r\nE na tua palidez\r\nE nos teus ardentes prantos\r\nSuspirar de languidez!\r\n\r\nQuero em teus lábios beber\r\nOs teus amores do céu,\r\nQuero em teu seio morrer\r\nNo enlevo do seio teu!Quero viver d’esperança,\r\nQuero tremer e sentir!\r\nNa tua cheirosa trança\r\nQuero sonhar e dormir!\r\n\r\nVem, anjo, minha donzela,\r\nMinha’alma, meu coração!\r\nQue noite, que noite bela!\r\nComo é doce a viração!E entre os suspiros do vento\r\nDa noite ao mole frescor,\r\nQuero viver um momento,\r\nMorrer contigo de amor!\n");
                            break;
                        case 6:
                            Console.WriteLine("Timidez (Cecília Meireles)\r\n\nBasta-me um pequeno gesto,\r\nfeito de longe e de leve,\r\npara que venhas comigo\r\ne eu para sempre te leve…– mas só esse eu não farei.Uma palavra caída\r\ndas montanhas dos instantes\r\ndesmancha todos os mares\r\ne une as terras mais distantes…– palavra que não direi.Para que tu me adivinhes,\r\nentre os ventos taciturnos,\r\napago meus pensamentos,\r\nponho vestidos noturnos,– que amargamente inventei.E, enquanto não me descobres,\r\nos mundos vão navegando\r\nnos ares certos do tempo,\r\naté não se sabe quando…– e um dia me acabarei.\n");
                            break;
                        case 7:
                            Console.WriteLine("Versos Íntimos (Augusto dos Anjos)\r\n\nVês?! Ninguém assistiu ao formidável\r\nEnterro de tua última quimera.\r\nSomente a Ingratidão – esta pantera –\r\nFoi tua companheira inseparável!\r\n\r\nAcostuma-te à lama que te espera!\r\nO Homem que, nesta terra miserável,\r\nMora entre feras, sente inevitável\r\nNecessidade de também ser fera\r\n\r\nToma um fósforo, acende teu cigarro!\r\nO beijo, amigo, é a véspera do escarro.\r\nA mão que afaga é a mesma que apedreja.\r\n\r\nSe alguém causa ainda pena a tua chaga\r\nApedreja essa mão vil que te afaga.\r\nEscarra nessa boca que te beija!\n");
                            break;
                        case 8:
                            Console.WriteLine("Que este amor não me cegue nem me siga (Hilda Hilst)\r\n\nQue este amor não me cegue nem me siga.\r\nE de mim mesma nunca se aperceba.\r\nQue me exclua do estar sendo perseguida\r\nE do tormento\r\nDe só por ele me saber estar sendo.\r\nQue o olhar não se perca nas tulipas\r\nPois formas tão perfeitas de beleza\r\nVêm do fulgor das trevas.\r\nE o meu Senhor habita o rutilante escuro\r\nDe um suposto de heras em alto muro.Que este amor só me faça descontente\r\nE farta de fadigas. E de fragilidades tantas\r\nEu me faça pequena. E diminuta e tenra\r\nComo só soem ser aranhas e formigas.Que este amor só me veja de partida.\n");
                            break;
                        case 9:
                            Console.WriteLine("Seiscentos e Sessenta e Seis (Mario Quintana)\r\n\nA vida é uns deveres que nós trouxemos para fazer em casa.\r\nQuando se vê, já são 6 horas…\r\nQuando se vê, já é 6.ª feira…\r\nQuando se vê, passaram 60 anos…\r\nAgora, é tarde demais para ser reprovado…\r\nE se me dessem – um dia – uma outra oportunidade,\r\neu nem olhava o relógio.\r\nseguia sempre, sempre em frente …\r\n\r\nE iria jogando pelo caminho a casca dourada e inútil das horas.\n");
                            break;
                        case 10:
                            Console.WriteLine("asamento (Adélia Prado)\r\n\nHá mulheres que dizem:\r\nMeu marido, se quiser pescar, pesque,\r\nmas que limpe os peixes.\r\nEu não. A qualquer hora da noite me levanto,\r\najudo a escamar, abrir, retalhar e salgar.\r\nÉ tão bom, só a gente sozinhos na cozinha,\r\nde vez em quando os cotovelos se esbarram,\r\nele fala coisas como “este foi difícil”\r\n“prateou no ar dando rabanadas”\r\ne faz o gesto com a mão.O silêncio de quando nos vimos a primeira vez\r\natravessa a cozinha como um rio profundo.\r\nPor fim, os peixes na travessa,\r\nvamos dormir.\r\nCoisas prateadas espocam:\r\nsomos noivo e noiva.\n");
                            break;
                        default:
                            Console.WriteLine("Número não associado a nenhum poema.");
                            break;
                    }
                }
                catch (FormatException) {
                    Console.WriteLine("Formato Inválido.");
                }
                catch (Exception e) {
                    Console.WriteLine($"Ocorreu um erro: {e.Message}");
                }
            }
        }

    }
}

