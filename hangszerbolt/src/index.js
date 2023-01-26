document.getElementById("form_feliratkozas").addEventListener("click",(p) => {
    if(emailEllenorzes(document.getElementById("form_email").value) && document.getElementById("form_vezeteknev").value.length>0 && document.getElementById("form_keresztnev").value.length>0)
    document.getElementById("hirlevel_form").submit();
});

document.getElementById("form_email").addEventListener("keyup",(p) => {
    document.getElementById("form_email").style.background = emailEllenorzes(document.getElementById("form_email").value) ? "rgba(0,255,0,0.2)" : "rgba(255,0,0,0.2)"; 
});

function emailEllenorzes(email) {
    const re = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
}