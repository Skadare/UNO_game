# UNO Game
# 1.	Цел на играта
Целта на следнава апликација е да се имплементира едноставна Uno игра помеѓу играч и бот. Играта се игра во кругови, и секој круг звршува кога еден од учесниците ќе ги потроши своите карти. 
Во секој круг на игра, играчот и ботот ги исфрлаат своите карти во согласност со бојата или бројот на картата која е на врвот на купот за исфрлање. Посебни карти како "Draw Two", "Skip", "Reverse", "Wild" и "Wild Draw Four" додаваат дополнителни правила и стратегии во играта. Кога играчот ќе остане со една карта во рака, мора да каже "Uno". Доколку ботот го фати играчот дека не кажал "Uno", играчот ќе подигне две карти како казна.
Главниот предизвик за играчот е да го надмудри ботот, кој е програмиран со различни стратегии за да ја направи играта интересна и возбудлива.

# 2.	Упатство за користење
  2.1 Нова игра
  
  На почетниот прозорец (слика 1) при стартување на апликацијата имаме можност да започнеме игра (Start Game), да ги видиме правилата на играта (How to play) и да излеземе од апликацијата.
  
![menu](https://github.com/Skadare/UNO_game/assets/139159619/9564da71-df53-4bc7-8206-de2abc606a91)

  2.2 How to play
  
  Доколку го кликнете копчето How to play ќе ви излезе прозорец на кои се објаснети основните правила за играта.	
  
  ![htp](https://github.com/Skadare/UNO_game/assets/139159619/a48fb214-3f7a-48cb-9468-c98a95fbb46f)

  2.3 Правила на играта
  
  Во нашата играта Uno, картите се поделени во неколку категории, секоја со своја функција и стратегија. Еве ги видовите карти и нивните правила:
  
  Овие карти се основните карти во играта и се нумерирани од 0 до 9.    Играчите ги играат овие карти врз основа на бојата или бројот на картата која е на врвот на купот за исфрлање.
  
  -	Црвени (0-9)
  -	Жолти (0-9)
  -	Сини (0-9)
  -	Зелени (0-9)

  Акциони карти

  Овие карти воведуваат специјални правила и можат да променат текот на играта.
  
1.	Skip (Прескокни):
     
    -	Кога ќе ја играте оваа карта, следниот играч (бот) ја пропушта својата редица.
3.	Reverse (Промени насока):
   	
    -	Кога ќе ја играте оваа карта, насоката на игра се менува.
4.	Draw Two (Земи две карти):
   	
    -	Следниот играч (бот) мора да земе две карти и ја пропушта својата редица.
5.	Wild:
   	
    -	Играчот кој ја игра оваа карта може да избере која било боја за следната карта, независно од бојата на картата која е на врвот на купот за исфрлање.
6.	Wild Draw Four:
   	
    -	Играчот кој ја игра оваа карта избира нова боја и следниот играч (бот) мора да земе четири карти и ја пропушта својата редица. Оваа карта може да се игра ако играчот нема друга карта во рака која одговара на бојата на картата на врвот на купот за исфрлање.


Правила за Играње на Карти

  1.	Боја или број: Играчот мора да исфрли карта која одговара на бојата или бројот на картата на врвот на купот за исфрлање.
     
  2.	Кога останува една карта: Кога играчот ќе остане со една карта во рака, мора да каже "Uno". Доколку не го направи тоа додека копчето е прикажано, играчот добива две карти како казна.
     
  3.	Земање карти: Ако играчот нема карта која може да ја игра, мора да земе карта од купот за земање. 

# 3. Претставување на проблемот

3.1.	Податочни структури

  За да играта функционира податоците и функциите ги ставивме во неколку класи: public class Player, public class Opponent, public class Deck, public class CardFactory и public abstract class Card од која наследуваат public class BlackCard и public class ColorCard. Исто така ни беа потребни четири форми.
  
Во класата Card чуваме податоци за типот на картата, бојата на картата, патека од    сликата. Типот и бојата се енумемирани а патеката е низа од знаци. Типот на картата може да биде Normal или WildCard, а бојата може да биде црвена, зелена, сина, золта и црна.

Карта е од тип Normal ако е било која карта освен Wild и Wild Draw Four. Во класата ColorCard чуваме податоци за бројот на картата, дали е Draw Two карта, Skip карта или Reverse.

Картата е од тип WildCard ако е Wild или Wild Draw Four. Во класата BlackCard чуваме податоци дали каратата е Wild Draw Four или Wild.

Во класата Player чуваме листа од карти. И имаме методи за да додадеме карта во листата и враќање на картата од специфична позиција.

Класата Opponent е иста како класата Player само имаме плус метод за да најдеме која боја на карти најмногу ја има ботот.


3.2.	Поважни функции

  a)	 checkLogic(Card c)  
  
  Функцијата checkLogic е приватна функција која ги проверува правилата на играта Uno при играње на карта од страна на играчот или ботот. Функцијата зема една карта c како влезен параметар и го враќа резултатот од проверката дали таа карта може легално да се одигра според тековните правила на играта.
  
  b)	CheckStateOfGame()
  
  Функцијата CheckStateOfGame() е приватна функција која проверува кој е победник и ни испраќа соодветна порака.

  c)	UNOcheck()
  
  Функцијата  UNOcheck() е приватна функција која проверува дали играчот има една карта.
  
  d)	timer2_Tick()
  
  Функцијата timer2_Tick() е приватна функција која го брше копчето за UNO, му дава 2 карти на играчот и му дава предност на ботот.

  e)	unoButton_Click()
  
  Функцијата unoButton_Click() е приватна функција која го допира тајмерот и го брише копчето UNO.


# Старт на играта

![startgame](https://github.com/Skadare/UNO_game/assets/139159619/4f4bdb04-d389-4bae-beb4-8ddce833a26c)

# Избирање на боја откако ќе се фрли Wild

![color](https://github.com/Skadare/UNO_game/assets/139159619/1c8cca3f-f6f3-40ef-b221-644740402354)

# УНО!

![uno](https://github.com/Skadare/UNO_game/assets/139159619/a5ff4d77-beec-4a6c-9b4e-ba418318d349)




  
