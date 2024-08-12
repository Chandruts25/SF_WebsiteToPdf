namespace SF_WebsiteToPdf
{
    public static class CustomStyle
    {
        public static string customCss = @"
            body { margin: 0; padding: 0; }
           .col-md-6, .col-md-12, .col-sm-12 {  max-width: 50%; }
           .dentaqual-overall-row {display: table; width: 100%;}
           .dentaqual-categories-row { width: 96%; margin-right: 2%; margin-left: 2%; border-bottom: 1px solid black; padding: 10px 13px;display: table; }
           .overall-categories-icon, .denta-qual-overall-content,.denta-qual-categories-icon, .denta-qual-categories-content, .categories-rating {  display: table-cell;vertical-align: top; }
           .categories-title {text-wrap: nowrap;}
           .denta-qual-categories-content.dentaqual-print-width-50 {margin-top: 0px;} 
           .categories-icon {margin-top: 45px;}
           .dentaqual-rating-text {text-align: right; margin-right: 45px;}
           .denta-qual-overall-icon {margin-top: 30px;}
           .denta-qual-overall-content {margin-top: 30px;}
           .overall-categories-icon {padding-top: 30px; }
           .dentaqual-contact-us-auto {display: none !important;}
           .dent-score-npi {display: none !important;}
           .row-full-width {width: 100%;}
           .dentaqual-footer-logo { margin-left: 125px;}
           #loginControlNav, .sticky-top {display: none;}
           .dentaqual-categories-row.categories-row-last { border: none; }
        ";
    }
}
