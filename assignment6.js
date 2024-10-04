const prompt=require("prompt-sync")();

function check_leapyear(){
    const year=prompt("Enter the year");
    if(year!=null)
    {
        if((year%400)==0)
        {
            return true
        }
        if((year%100)!=0)
        {
            if((year%4)==0)
            {
                return true
            }
        }
        return false
    }
}
var result=check_leapyear();
console.log(result)


