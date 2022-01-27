const timeElements = document.querySelectorAll(".time")
// creating a format for the time
const format = new Intl.DateTimeFormat("en-se", {
    year: "numeric", month: "numeric", day: "numeric",
    hour: "numeric", minute: "numeric", second: "numeric"
})


window.addEventListener("load", () => {
    timeElements.forEach(element => {
        // update the time every 499ms, this should make sure no seconds are skipped.
        setInterval(() => {
            element.innerHTML = format.format(new Date()).replace(",", "") // removing ,
        }, 499)
    })
})