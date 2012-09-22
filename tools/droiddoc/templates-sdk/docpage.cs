<?cs include:"doctype.cs" ?>
<?cs include:"macros.cs" ?>
<html>
<?cs include:"head_tag.cs" ?>
<body class="gc-documentation
  <?cs if:(guide||develop||training||reference||tools||sdk) ?>develop<?cs if:guide ?> guide<?cs /if ?><?cs
  elif:about ?>about<?cs
  elif:design ?>design<?cs
  elif:distribute ?>distribute<?cs
  /if ?>" itemscope itemtype="http://schema.org/Article">
<a name="top"></a>
<?cs include:"header.cs" ?>

<div <?cs if:fullpage
?>class="fullpage"<?cs elif:design||tools||about||sdk||distribute
?>class="col-13" id="doc-col"<?cs else 
?>class="col-12" id="doc-col"<?cs /if ?> >

<?cs if:(design||training||walkthru) ?><?cs # header logic for docs that provide previous/next buttons ?>
  <?cs if:header.hide ?>
  <?cs else ?>
  <div class="layout-content-row content-header <?cs if:header.justLinks ?>just-links<?cs /if ?>">
    <div class="layout-content-col <?cs if:training ?>span-7<?cs else ?>span-9<?cs /if ?>">
      <?cs if:header.justLinks ?>&nbsp;
      <?cs else ?><h1 itemprop="name"><?cs var:page.title ?></h1>
      <?cs /if ?>
    </div>
    <?cs if:training ?>
      <div class="training-nav-top layout-content-col span-5" itemscope itemtype="http://schema.org/SiteNavigationElement">
        <a href="#" class="prev-page-link hide">
              <span class="en">Previous</span>
              <span class="zh-TW" style="display:none">上一堂課</span>
              <span class="zh-CN" style="display:none">上一课</span>
              <span class="ru" style="display:none;font-size:85%">Предыдущий</span>
              <span class="ko" style="display:none">이전</span>
              <span class="ja" style="display:none">前へ</span>
              <span class="es" style="display:none">Anterior</span>
        </a>
        <a href="#" class="next-page-link hide">
              <span class="en">Next</span>
              <span class="zh-TW" style="display:none">下一堂課</span>
              <span class="zh-CN" style="display:none">下一课</span>
              <span class="ru" style="display:none;font-size:85%">Следующий</span>
              <span class="ko" style="display:none">다음</span>
              <span class="ja" style="display:none">次へ</span>
              <span class="es" style="display:none">Siguiente</span>
        </a>
        <a href="#" class="start-class-link hide">
              <span class="en">Get started</span>
              <span class="zh-TW" style="display:none">開始上課</span>
              <span class="zh-CN" style="display:none">开始</span>
              <span class="ru" style="display:none">Начало работы</span>
              <span class="ko" style="display:none">시작하기</span>
              <span class="ja" style="display:none">開始する</span>
              <span class="es" style="display:none">Empezar</span>
        </a>
        <a href="#" class="start-course-link hide">
              <span class="en">First class</span>
              <span class="zh-TW" style="display:none">第一堂課</span>
              <span class="zh-CN" style="display:none">第一课</span>
              <span class="ru" style="display:none">Первый урок</span>
              <span class="ko" style="display:none">첫 번째 강의</span>
              <span class="ja" style="display:none">最初のクラス</span>
              <span class="es" style="display:none">Primera clase</span>
        </a>
      </div>
    <?cs else ?>
      <div class="paging-links layout-content-col span-4" itemscope itemtype="http://schema.org/SiteNavigationElement">
        <a href="#" class="prev-page-link hide">
          <span class="en">Previous</span>
          <span class="zh-TW" style="display:none">上一堂課</span>
          <span class="zh-CN" style="display:none">上一课</span>
          <span class="ru" style="display:none;font-size:85%">Предыдущий</span>
          <span class="ko" style="display:none">이전</span>
          <span class="ja" style="display:none">前へ</span>
          <span class="es" style="display:none">Anterior</span>
        </a>
        <a href="#" class="next-page-link hide">
          <span class="en">Next</span>
          <span class="zh-TW" style="display:none">下一堂課</span>
          <span class="zh-CN" style="display:none">下一课</span>
          <span class="ru" style="display:none;font-size:85%">Следующий</span>
          <span class="ko" style="display:none">다음</span>
          <span class="ja" style="display:none">次へ</span>
          <span class="es" style="display:none">Siguiente</span>
        </a>
      </div>
    <?cs /if ?><?cs # end if training ?>
  </div>
  <?cs /if ?>
<?cs else ?>
  <?cs if:(!fullpage && !header.hide) ?>
    <?cs if:page.landing ?><?cs # header logic for docs that are landing pages ?>
      <div class="landing-banner">
        <?cs if:page.landing.image ?><?cs # use two-column layout only if there's an image ?>
        <div class="col-6">
          <img src="<?cs var:toroot ?><?cs var:page.landing.image ?>" alt="" />
        </div>
        <div class="col-6">
        <?cs /if ?>
          <h1 itemprop="name" style="margin-bottom:0;"><?cs var:page.title ?></h1>
          <p itemprop="description"><?cs var:page.landing.intro ?></p>
          
          <p><a class="next-page-link topic-start-link"></a></p>
        <?cs if:page.landing.image ?>
        </div>
        <?cs /if ?>
      </div>
    <?cs else ?>
      <h1 itemprop="name"><?cs var:page.title ?></h1>
    <?cs /if ?>
  <?cs /if ?>
<?cs /if ?><?cs # end if design ?>

  <?cs # THIS IS THE MAIN DOC CONTENT ?>
  <div id="jd-content">


    <div class="jd-descr" itemprop="articleBody">
    <?cs call:tag_list(root.descr) ?>
    </div>
      
      <div class="content-footer <?cs 
                    if:fullpage ?>wrap<?cs
                    else ?>layout-content-row<?cs /if ?>" 
                    itemscope itemtype="http://schema.org/SiteNavigationElement">
        <div class="layout-content-col <?cs 
                    if:fullpage ?>col-16<?cs 
                    elif:training||guide ?>col-8<?cs 
                    else ?>col-9<?cs /if ?>" style="padding-top:4px">
          <?cs if:!page.noplus ?><?cs if:fullpage ?><style>#___plusone_0 {float:right !important;}</style><?cs /if ?>
            <div class="g-plusone" data-size="medium"></div>
          <?cs /if ?>
        </div>
        <?cs if:!fullscreen ?>
        <div class="paging-links layout-content-col col-4">
          <?cs if:(design||training||guide||walkthru) && !page.landing && !footer.hide ?>
            <a href="#" class="prev-page-link hide">
              <span class="en">Previous</span>
              <span class="zh-TW" style="display:none">上一堂課</span>
              <span class="zh-CN" style="display:none">上一课</span>
              <span class="ru" style="display:none;font-size:85%">Предыдущий</span>
              <span class="ko" style="display:none">이전</span>
              <span class="ja" style="display:none">前へ</span>
              <span class="es" style="display:none">Anterior</span>
            </a>
            <a href="#" class="next-page-link hide">
              <span class="en">Next</span>
              <span class="zh-TW" style="display:none">下一堂課</span>
              <span class="zh-CN" style="display:none">下一课</span>
              <span class="ru" style="display:none;font-size:85%">Следующий</span>
              <span class="ko" style="display:none">다음</span>
              <span class="ja" style="display:none">次へ</span>
              <span class="es" style="display:none">Siguiente</span>
            </a>
          <?cs /if ?>
        </div>
        <?cs /if ?>
      </div>
      
      <?cs # for training classes, provide a different kind of link when the next page is a different class ?>
      <?cs if:training ?>
      <div class="layout-content-row content-footer next-class" style="display:none" itemscope itemtype="http://schema.org/SiteNavigationElement">
          <a href="#" class="next-class-link hide">Next class: </a>
      </div>
      <?cs /if ?>

  </div> <!-- end jd-content -->

<?cs include:"footer.cs" ?>
</div><!-- end doc-content -->

<?cs include:"trailer.cs" ?>

</body>
</html>



