
/**
 * Class for calculate how many plates that they eat
 */
function Ramen()
{
    var FULLPLATESCOUNT = 5;
    var _count = 0;
    var _plates = 0;

    this.Eat = function (divid)
    {
        _count += 1;        
        if (_count >= FULLPLATESCOUNT)
        {
            _plates += 1;
            this.ShowScore(divid);            
            _count = 0;
        }
    };

    this.ShowScore = function (divid)
    {
        var str = "<span class='label label-default>" + _plates + "</span>";              
        $("#" + divid).html("<b> Plates: "+_plates+"</b>");
        //$("#divPlates").append(str);
        
    }
}