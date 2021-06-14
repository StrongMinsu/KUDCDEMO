var Employee = { //객체 리터럴 표기법
    //필수 정보는 근무자 이름, 주소, 연락처, 사업체명, 서명
    name : 'payitem_test'
    //address : '',
    
};



function saveToFile_Chrome(fileName, content) { //txt 파일로 생성 및 다운로드
    var blob = new Blob([content], { type: 'text/plain' });
    objURL = window.URL.createObjectURL(blob);
            
    // 이전에 생성된 메모리 해제
    if (window.__Xr_objURL_forCreatingFile__) {
        window.URL.revokeObjectURL(window.__Xr_objURL_forCreatingFile__);
    }
    window.__Xr_objURL_forCreatingFile__ = objURL;
    var a = document.createElement('a');
    a.download = fileName;
    a.href = objURL;
    a.click();
}




  function jsonPrint(form){ //값이 있을 때만 출력하자
    if(form!="")
    return form;
  }


/*
function downloadURI(uri, name){ //서명 저장
	var link = document.createElement("a")
	link.download = name;
	link.href = uri;
	document.body.appendChild(link);
	link.click();
}

function Signature(){
    var canvas = $("#signature")[0];
    var signature = new SignaturePad(canvas, {
        minWidth : 2,
        maxWidth : 2,
        penColor : "rgb(0, 0, 0)"
    });

    $("#reset_sign").on("click", function() {
        signature.clear();
    });
    
    $("#make_contract").on("click", function() {
        if(signature.isEmpty()) {
            Employee.signDataURL = '';
        } else {
            var data = signature.toDataURL("image/png"); //캠버스 영역을 base64값으로 즉시 변환
            Employee.signDataURL = data;  // 컨트랙트 txt에 이미지의 base64 문자열 저장.
            //downloadURI(data,"sign.png"); // 서명 파일로 저장 (사실 base64 문자열만 저장해도 무방함)
        }
    });
}
*/
  
window.onload = function(){ //webpage의 모든 구성요소에 대한 로드가 끝났을 때 브라우저에 의해서 호출되는 함수(이벤트)
    
    //renewalDate('write_year','write_month','write_day');// 작성일 갱신 함수
    //Signature(); //서명 함수
    
    var contract = document.getElementById('make_contract');
    contract.addEventListener('click',function(){
        
            //필수입력 항목 
            Employee.name = "hello";
           // Employee.address = document.getElementById('EmployeeModel_EmployeeAddress').value;
           
           // Employee.phone = document.getElementById('EmployeeModel_EmployeeContactUs').value;
           // Employee.companyName = document.getElementById('BossModel_CompanyName').value;

            //선택입력 항목
            /* 계약기간 */
            /*
            Employee.start_year= jsonPrint(document.getElementById('StandardModel_ContractStartDate_Value_Year').value)
            Employee.start_month= jsonPrint(document.getElementById('DevStMonth').value);
            Employee.start_day= jsonPrint(document.getElementById('DevStDay').value);
            if(Employee.start_month==null || Employee.start_day==null)
            {
                Employee.start_year=undefined; // 근로개시년만 기재되어 있을 경우 출력x
            }

            Employee.end_year= jsonPrint(document.getElementById('StandardModel_ContractEndDate_Value_Year').value);
            Employee.end_month= jsonPrint(document.getElementById('DevEdMonth').value);
            Employee.end_day= jsonPrint(document.getElementById('DevEdDay').value);
            if(Employee.end_month==null || Employee.end_day==null)
            {
                Employee.end_year=undefined; // 근로개시년만 기재되어 있을 경우 출력x
            }
            */

            /*근무장소,업무내용, 근로 시작시간, 근로 종료시간 */

            /*
            Employee.work_place= jsonPrint(document.getElementById('workPlace').value);
            Employee.work_content= jsonPrint(document.getElementById('workContent').value);
            Employee.work_start_time= jsonPrint(document.getElementById('StandardModel_WorkStartTime').value);
            Employee.work_end_time= jsonPrint(document.getElementById('StandardModel_WorkEndTime').value);
            */
            /*근무일 및 휴일*/
            //Employee.work_day_num= checkRadio(document.getElementsByName('StandardModel.WeekWorkDateCnt'));

            //if(checkBox(document.getElementsByName('WeekWorkHoliday')!=''))
            //{
            //    Employee.holiday= checkBox(document.getElementsByName('WeekWorkHoliday'));
            //}
            //else
            //{
            //    Employee.holiday= undefined;
            //}

            /*임금 형태 */
            //Employee.pay_format= checkRadio(document.getElementsByName('StandardModel.PayTypeCode'));
            //Employee.pay_amount= jsonPrint(document.getElementById('pay_amount').value); //임금
            
        

        if((Employee['name']!='')) //필수입력공간이 전부 null이 아닐 때만
        {
            var recardianData = JSON.stringify(Employee,null,3); // 제이슨 객체를 String 객체로 변환, 반대로 JSON.parse()는 string 객체를 json 객체로 변환한다. null과 3은 정렬을 위해서다.
            saveToFile_Chrome("item.txt",recardianData); // Chrome 환경에서, 오른쪽 인수의 내용을 txt 파일로 다운로드한다, download 폴더 경로로 저장된다.
            alert('컨트랙트 생성 완료');
        }
        else
        {
            alert('필수 항목을 반드시 입력해주세요');
        }

    })
}
    