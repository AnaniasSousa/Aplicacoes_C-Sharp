using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiinhaCalculadora_de_Signos
{
    class Profeta
    {
//      ARRAY
        private Tribo[] tribos = new Tribo[12];

//      CONSTRUTOR DO ARRAY
        public Profeta ()
        {
            tribos[0] = new Tribo
            {
                diaInicio = 21,
                mesInicio = 1,
                diaFim = 19,
                mesFim = 2,
                nome = "Rubem",
                caracteristicas = "Reuvenitas são os Yisraelitas, que tem um ahavah (se entregam) para a carnalidade e a sensualidade, apesar de sua regeneração. Eles têm uma grande luta entre o certo e o errado e eles são relativamente poucos. Encontrado principalmente entre os franceses. Eles conseguem muitos empreendimentos diferentes, inicialmente, mas não têm continuidade na justiça. Assim, o seu sucesso se vira para os repetidos fracassos. -> Fonte: http://aliancanetsarimbrasil.com.br"
            };
            tribos[1] = new Tribo
            {
                diaInicio = 20,
                mesInicio = 2,
                diaFim = 20,
                mesFim = 3,
                nome = "Shimon e Levi",
                caracteristicas = "Os levitas têm vários traços de personalidade-chave. Eles devem ser separados de todo Yisrael pelo castigo, ódio e raiva deslocada. Eles não têm uma herança em terras e em suas andanças globais vão ser separados do mundo e do povo de Yisrael. Eles são encontrados hoje em todas as tribos de Yisrael. Shimeon também herdará as partes menos desejáveis ​​da terra kadosh. Seu temperamento é infame e causa muitos problemas. Yisraelitas com mau humor e vive instáveis se ​​encaixam nessa características. No função do êxodo, Levi serviria a YHWH no altar e depois foi separado de sua casa e ele seria o ministro da Torá para todo o Yisrael. Muitos rabinos tradicionais e funcionários da sinagoga, como cantores e korehsbal, (leitores Torah) podem ser encontrados para serem de Levi. Muitos daqueles que ensinam a Torá hoje, bem como a Torá do Messias que se identificam, como os judeus são levitas, apesar do fato de que eles não sabem a quem é sua mãe ou o pai e não pude provar seu status levítico. YHWH irá sempre proteger levitas, enquanto eles continuarem fiéis à sua vocação. Moshe não fez profecia sobre Shimeon, pois nunca Shimeon apresentou quaisquer qualidades redentoras a Moshe ou antes de YHWH. Eles não tinham e continuam sem arrependimento. Disse que estão sendo Yisraelitas na Europa Ocidental e os descendentes da Europa Ocidental, (Escócia, Irlanda) com espíritos medianos e temperamentos quentes, a maioria dos quais não são crentes nas Escrituras.   -> Fonte: http://aliancanetsarimbrasil.com.br"
            };
            tribos[2] = new Tribo
            {
                diaInicio = 21,
                mesInicio = 3,
                diaFim = 20,
                mesFim = 4,
                nome = "Yahudah",
                caracteristicas = "Yahudah (Judah) levará Yisrael no campo de batalha militar e espiritual, e na estabelecida real Casa de Davi. O Messias fará todo o Yisrael se curvar e adorar, apesar da perseguição escura do Messias e de Judah. Judah conhece tanto o triunfo e a melancolia. A autoridade de Moisés reside em Judá até que venha Shiloh, ele é então escondido em Gad. Aqueles que prosperam em assuntos espirituais e revelação, e que a correta interpretação da Brit Chadashah à luz da Torá e que são lavados no sangue do Messias seriam de Judáh messiânico. Judaítas hoje são também os judeus que têm o desejo de um coração ardente de reunir as duas casas como visto na declaração de Moshe em trazer Judá devolta para o restante de seu povo. Os judaítas de hoje são soldados no campo de batalha contra os grandes inimigos da moderna Yisrael.    -> Fonte: http://aliancanetsarimbrasil.com.br"
            };
            tribos[3] = new Tribo
            {
                diaInicio = 21,
                mesInicio = 4,
                diaFim = 20,
                mesFim = 5,
                nome = "Zevulon",
                caracteristicas = "Aqueles que se identificam como Yisraelitas e amam o mar e se estabelecem perto do mar pode ser de Zevulun. Um amor para atividades relacionadas com a água no comércio e lazer é um sinal de pessoas de Zevulon nos últimos dias.   -> Fonte: http://aliancanetsarimbrasil.com.br"
            };
            tribos[4] = new Tribo
            {
                diaInicio = 21,
                mesInicio = 5,
                diaFim = 20,
                mesFim = 6,
                nome = "Yissaker",
                caracteristicas = "Yisacharitas estão na vanguarda do último dia da restauração das duas casas Yisrael. A maioria dos líderes das duas casas, na verdade que não são de Judáh ou judeus são de Yissachar. Podemos afirmar isso porque na profecia de YAAKOV sobre Yissachar e mentiras entre os dois fardos ou a carga dupla em reunir as duas famílias de Yisrael dispersa. Estar sujeito ao trabalho escravo significa que estes são indivíduos que se fizeram servos em carregar o fardo duplo. Yissachar está disposto a servir como intermediário para as duas casas, porque ele vê o lugar resultante de descanso da volta a paz na terra agradável no prêmio final. Yissacharitas são aqueles hoje em Yisrael, que compreendem os tempos de restauração em que vivemos, e estão dispostos a carregar um fardo das duas casas em seus ombros, para o bem do resto que está à frente, quando o país for totalmente restaurado. Yissacharitas se opõem ao dispensacionalismo.   -> Fonte: http://aliancanetsarimbrasil.com.br"
            };
            tribos[5] = new Tribo
            {
                diaInicio = 21,
                mesInicio = 6,
                diaFim = 21,
                mesFim = 7,
                nome = "Dan",
                caracteristicas = "Dan vai ser forte na batalha contra o anti messias islâmico no tempo final . Dan está em seu caminho, em Basã, ou no Líbano e em outros lugares, sem dúvida todo o império islâmico no tempo final. Julgamentos de Dan profecia e apostasia estão justas, como ele mesmo reconhece apostasia no Islã, pois ele também tem um fundo nisso. Mas nos últimos dias, Dan terá sua mente renovada, de modo a se opor ao cavaleiro do cavalo branco, o anti messias islâmico, por isso que o programa mal do anti messias para destruir duas casas de Yisrael vai cair por terra e não vingará. Dan enquanto se opõem ao Islã, aguarda o retorno de Yahushua para terminar com a besta, como muitos de Dan estão despertando para suas raízes Torá. Dan atua como um leão corajoso em defesa de Yisrael, saltando de Basã, ou mesmo dentro de terras islâmicas ou fortalezas.    -> Fonte: http://aliancanetsarimbrasil.com.br"
            };
            tribos[6] = new Tribo
            {
                diaInicio = 22,
                mesInicio = 7,
                diaFim = 22,
                mesFim = 8,
                nome = "Gad",
                caracteristicas = "Gad estaria envolvido na derrubada dos últimos dias físicamente do filho de Dan”, o anti Messias, na batalha do Armagedom, e seria uma tropa de guerreiros para YHWH contra as forças do compromisso ecumênico, defendendo os mishpatim de YHWH (Torá) para todo o Yisrael. Aqueles que corajosamente e profeticamente enfrentam as formas de ecumenismo rebelde de Dan, pode muito bem ser de Gad. À luz do afastamento temporário do cetro e bastão de Judáh, primeiro Shiloh, o cetro e dando direito, hoje a responsabilidade (halachica) para levar todo Yisrael de volta para a justiça pertence a Gad. Gad tem a coroa e legisladoria escondida na tribo e da Torá escondida no coração de Gad regenerado! Este último dia o papel de Gad não foi e não pode ser cumprido pela assim chamada Igreja, porque que ela odeia a Torá e os mishpatim de YHWH. Além disso, ela não sessa unicamente com o povo de Yisrael judaico. O Último dia Gad será despertado ao seu único papel no passado recente principalmente desde 1996 dM, quando a punição de Efraim chegou ao fim (Veja a Parte 21 “O Mistério do Cetro Oculto”) em www.yourarmstoisraelglobal.compara uma explicação completa do cetro escondida em Gad ). Gad foi efraimita ampliado e muitas das 10 tribos são encontradas em Gad como esses efraimitas em Gad que estabelecem a Halachá e Mat. 16 a autoridade em Yisrael restaurado. Gad tornou-se o jogador importante no estabelecimento da Torá e na halachá para todo o Yisrael, no período primeiro para a segunda vinda. Efraimitas e judaítas, que defendem o Messias Yahushua e ensinam Torá, podem muito bem ser parte do tempo do fim ampliado e totalmente fiel restaurado Gad, invadindo as atividades, muitas vezes ocultas de Dan, dentro “igregismo”. Eles são provavelmente encontrados com o chamado das trombetas de Rev. 18:4 “Sai dela povo meu [Yisrael]”    -> Fonte: http://aliancanetsarimbrasil.com.br"
            };
            tribos[7] = new Tribo
            {
                diaInicio = 23,
                mesInicio = 8,
                diaFim = 22,
                mesFim = 9,
                nome = "Asher",
                caracteristicas = "Asher significa rico em hebraico. Os descendentes de hoje de Asher, pode ser encontrados entre os judeus, cristãos e árabes, mesmo que misturados com os Yisraelitas. Através de uma variedade de transações comerciais dessas pessoas nos negócios atingiram grande riqueza e sucesso financeiro. A bênção financeira de Asher excede todas as outras tribos, assim como muitos dos reis da terra e rainhas. Até mesmo os sapatos são de qualidade. Eles tendem a viver vidas mais longas, cheias de vitalidade do que os seus irmãos em Yisrael. Asheritas são uma parte vital da restauração de Yisrael, como eles estão sendo chamados para financiar a restauração materialmente e não devem ser olhados com inveja pelos demais Yisraelitas. Muitos asheritas são encontrados no negócio do petróleo ou em indústrias de petróleo relacionados. Ele mergulha os pés nos negócios de petróleo. O falecido magnata do petróleo Leon Hess e George Bush pai seriam exemplos possíveis de Asher.    -> Fonte: http://aliancanetsarimbrasil.com.br"
            };
            tribos[8] = new Tribo
            {
                diaInicio = 23,
                mesInicio = 9,
                diaFim = 22,
                mesFim = 10,
                nome = "Naftali",
                caracteristicas = "Naftali deu origem a muitos professores das Escrituras e cinco ministros, principalmente na Casa de Efraim. As palavras Naftalitas são mais elegantes e eloquentes, pois pregam e ensinam as palavras do Rei Yahushua. Muitos são os evangélicos que falam palavras do Evangelho de elegância que vêm de seus lábios. Muitos naftalitas são caracterizados por uma tendência para a adoção dos presentes e cheios do Ruach HaKodesh, (sopro de YAH), como eles se entregam no Ruach. No que diz respeito à restauração das duas casas de Yisrael, embora os crentes nele, Naftali, muitas vezes opta por não “se desviar” das duas casas na restauração e se concentra principalmente na do sangue de Yahushua, chamando todo o Yisrael ao sangue de Yahushua através de pregação do evangelho e uma subsequente relação com Yahuah. Eles são mais propensos a ensinar sobre o batismo do ruach, em seguida, a restauração das duas casas. Naftalitas tem a tendência a serem profeticamente míopes. Naftali tem prazeres espirituais e bênçãos, por ofegante depois de um relacionamento com o Kadoshde Yisrael. Sua pregação se espalha a oeste para a Europa e para o sul para as Américas.    -> Fonte: http://aliancanetsarimbrasil.com.br"
            };
            tribos[9] = new Tribo
            {
                diaInicio = 23,
                mesInicio = 10,
                diaFim = 21,
                mesFim = 11,
                nome = "Benyamin",
                caracteristicas = "Binyamin é composto de muitos hipócritas nos últimos dias do Yisrael físico. Durante o dia, eles parecem ser poderosos combatentes que lutam para o bem de Yisrael e sua sobrevivência poderosa. Mas antes do amanhecer e depois do anoitecer, eles secretamente se sentam à mesa de paz com os inimigos de YHWH e fazem aliança de morte e sepultura. Estes Beniamitas, como o rei Shaul, são encontrados principalmente em cargos de liderança do moderno Estado de Yisrael. Os Beniamitas dizem uma coisa publicamente e sob a escuridão fazem outras coisas. Os judeus em Yisrael hoje tem uma elevada percentagem destes Beniamitas, que são como lobos, vestidos em pele de cordeiro. A maioria dos beniamitas são encontrados na Casa de Judáh. A maioria dos Beniamitas não são crentes no Messias. Devido a esta traição à nação, Moshe em desgosto parece evitar até mesmo mencionar o seu nome, pois eles não são localizado em Devarim/Deuteronômio 33!    -> Fonte: http://aliancanetsarimbrasil.com.br"
            };
            tribos[10] = new Tribo
            {
                diaInicio = 22,
                mesInicio = 11,
                diaFim = 21,
                mesFim = 12,
                nome = "Efraim",
                caracteristicas = "Hoje, os da tribo de Efraim ou José são duplamente frutífera e são encontrados em todas as tribos de Israel, todas as religiões do mundo, apóstatas, e em todas as nações de Israel. Apesar de os arqueiros, inimigos [de retorno do Yoseph] que tentaram manter o seu papel oculto e separado do judeu-Israel, Joseph venceu por YHWH e reafirmando-se como um herdeiro legítimo de Israel. Em Gênesis 49: versículo 24, temos outra confirmação de que entre as primeira e segunda vindas , o cetro [ Shevet-tribo ] ea coroa de autoridade lawgiving [ chaqaq ] em Israel, vai descansar em e entre as pessoas de José ou mais especificamente Joseph dentro Gad alargada , que é ampliada para segurar José, em seu retorno a Israel de entre as nações. Bênçãos espirituais e físicas são todos ligados em um pacote em José-Efraim, junto com a promessa de multiplicação em larga escala física no ventre e os seios das mulheres de José-Efraim. ( Ver série inteira sobre a restauração de Israel em Www.Yourarmstoisrael.Org ) bênçãos eternas de vida eterna (o evangelho) também são confiadas a Joseph. Massas de descendência Yoseph vai herdar montes eternos, [a vida eterna], que disse Jacó era muito maior do que qualquer herança terrena ele ou seus pais haviam recebido. José terá os escolhidos posses na terra santa quando é reassentados. Aqueles que gostam de estas bênçãos frutíferas no Espírito e no natural são a prometida hagoyim melo ou plenitude dos gentios. Através de Efraim-Joseph-Israel, YHWH fisicamente preencher todas as nações dos últimos dias da Terra. Yoseph é muitas vezes sinônimo de Efraim, como encontrado em Apocalipse 07:08 e 37:16 Ezequiel.    -> Fonte: http://aliancanetsarimbrasil.com.br"
            };
            tribos[11] = new Tribo
            {
                diaInicio = 22,
                mesInicio = 12,
                diaFim = 20,
                mesFim = 1,
                nome = "Manassés",
                caracteristicas = "Manassés foi dito para se tornar uma única nação grande promessa dentro de José de fecundidade de acordo com Gênesis 48:19. Como Yoseph experimentou o desespero da separação de seus irmãos em dias anteriores, nos últimos dias-Yoseph, na forma como vai saber a alegria da restauração nacional. Manassés tornou-se principalmente uma única nação grande conhecido hoje como os Estados Unidos da América. Manassés substitui a tribo de Dã em Apocalipse 7:6, como castigo de YHWH sobre Dan por ser responsável pela adoração do bezerro de ouro que eles trouxeram sobre Israel, tanto em dias passados, bem como até o dia de hoje. YHWH não veda qualquer de Dan na Grande Tribulação, em vez de vedação muitos de Manassés. Crentes mais bíblia que não pode e não especificamente se enquadrar nas características das outras tribos, são Efraim ou Manassés, talvez, se eles vivem nos EUA ou em qualquer de suas terras conexas e são fiéis crentes na Bíblia. Efraim também é encontrada entre os filhos de Ismael e Esaú, que não tenham adoptado a fé muçulmana, como os cristãos libaneses. O Unicórnio tem apenas um chifre, simbolizando que apenas uma casa , [10 tribos coletivos de Joseph-Efraim] será o principal responsável por empurrar Israel para todas as nações.    -> Fonte: http://aliancanetsarimbrasil.com.br"
            };

        }

//      METODO
        public Tribo OuvirDeus(uint dia, uint mes)
        {
            Tribo tribo = null;
//          LAÇO DE REPETIÇÃO
            for (uint i = 0;i < tribos.Length;i++)
            {
//              CONDIÇÃO
                if ((dia >= tribos[i].diaInicio && mes == tribos[i].mesInicio) || (dia <= tribos[i].diaFim && mes == tribos[i].mesFim))
                {
                    tribo = tribos[i];
                }
            }
            return tribo;
        }


    }
}
