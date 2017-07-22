
/**
 * Class for calculate how many plates that they eat
 */
function Ramen()
{
    var fullplatescount = 5;
    var count = 0;
    var plates = 0;

    this.Eat = function (divid)
    {
        count += 1;        
        if (count >= fullplatescount)
        {
            plates += 1;
            this.ShowScore(divid);            
            count = 0;
        }
    };

    this.ShowScore = function (divid)
    {
        var str = "<span class='label label-default>" + plates + "</span>";              
        $("#" + divid).html("<b> Plates: "+plates+"</b>");
        //$("#divPlates").append(str);
        
    }
}