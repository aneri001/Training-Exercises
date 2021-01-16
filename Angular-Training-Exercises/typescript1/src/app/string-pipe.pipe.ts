
import {Pipe,PipeTransform} from '@angular/core';


@Pipe({name:'stringWrap'})
export class stringWrap implements PipeTransform{
 
    transform(data: any): any{
        //this is very long string
        var value1 = data.substr(0,7);
        value1= value1 +'...'
        return value1;
    }
}
