# Инструкции за употреба

## Login форма
* Login - влизане в съществуващ акаунт
* Register - съдаване на нов акаунт

Няма аудентикация, за по лесен достъп до приложението

## Form Market
След като влезете/съдадете профила си бивате пратен в главната форма на приложението
* Buy case - закупува case и го слага във вашия инвентар. Цената на case е 2.50
  - За да отворите case трябва да double click-нете на case-а в инвентара.
    - В замяна получавате random item (всеки item има рядкост обозначена с цвета на текста на item-a)
        - Цветовете спрямо рядкост са: Син, Лилав, Розов, Червен - най-рядък.
* Market - използва се да продажба и закупуване на item
  - За да сложите item за продажба трябва да double click-нете върху него

* Item Double Click - показва подобрна информация за item, показва снимката на item и допълнителни детайли
    
* Tradeup - служи за upgrade на качеството на item
  - преди да кликнете бутона трябва да изберете 10 item-а от инвентара
  - избирането става чрез задържане на бутона ctrl и избиране на съответните item-и
  - тези 10 item-а биват премахнати от инвентара в замяна за 1 item от по-високо качество.
    
* Friends - отваря менюто за приятели

* Offers - отваря менюто с оферти, изпратени от приятели

* Search box - служи за търсене на item в инвентара

* Logout - изход от приложението

## Form market
използва се за закупуване на item
* След натискане на бутона Buy, ако имате достатъчно парите получавате item-a.
* Продавача получава парите, при продажба
* Ако е ваш listing-a и кликнете buy директно го получавате.
* Search box - служи за търсене на item. След като сте решили кой item искате. Пишете името му и съответно избирате. Listing-ите са подредени по цена.

## Friends
Показва приятелите и поканите за приятелство.
* бутон Friends - показва приятелите
  - при double click на приятел можете да видите инвентара му и да му предложите trade оферта, като изберете item-и от вашия и от неговия инвентар.
* бутон Penidng - показва поканите за приятелство изпратени от други потребители
* бутон Add - при натискане на този бутон се изпраща покана на потребителя, чието име е 
написано в textbox-а.
  
Note: След добавяне на играч излиза само в pending friends list-a на играча.

## Offers
Тук се показват офертите
* При Double click се отваря самата оферта, от където може да бъде приета или отказана

# Проблеми

- Лиспсват делегати, оказа се че не могат да бъдат сериализирани. Затова временно съм ги махнал докато не намеря по-добро рение. Реших че е по-добре данните да се запазват, отколкото да има делегати, понеже иначе няма да може да има взаимодействие между потребители. Мисля че най-добрия варянт ще е изпозлван е на MySQL, но незнам дали е позволено да го използвам.

# Testing

За тестове можете да изпозлвате "test" като username в login формата.