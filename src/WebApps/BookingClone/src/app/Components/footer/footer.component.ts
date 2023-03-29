import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {
  ngOnInit(): void {
    // Remove decoration(underline) from all anchor tags in footer
    var footerLinks = document.querySelectorAll("#footerLinks>div>div>ul>li>a")
      .forEach(element => {
        element.classList.add("text-decoration-none")
      })
  }

}
