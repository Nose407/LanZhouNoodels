using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouNoodleCJ.Modles
{
    public static class DBIntiallzer
    {

        public static void IntiNoodles(AppDbContext context) {
            if (context.Noodles.Any())
            {
                return;
            }
            context.AddRange(
                new Noodle { Name = "毛细", Price = 12, Introduce = "真的好细好细好细啊", ImgUrl = "/images/毛细.png", CreateTime = DateTime.Now },
                new Noodle { Name = "细", Price = 10, Introduce = "还是挺细的", ImgUrl = "/images/细.png", CreateTime = DateTime.Now },
                new Noodle { Name = "三细", Price = 11, Introduce = "比细的粗点，比二细细点", ImgUrl = "/images/三细.png", CreateTime = DateTime.Now },
                new Noodle { Name = "二细", Price = 10, Introduce = "粗的才有嚼劲", ImgUrl = "/images/二细.png", CreateTime = DateTime.Now },
                new Noodle { Name = "二柱子", Price = 11, Introduce = "粗得快咬不动了", ImgUrl = "/images/二柱子.png", CreateTime = DateTime.Now },
                new Noodle { Name = "韭叶子", Price = 12, Introduce = "韭猜叶一样宽", ImgUrl = "/images/韭叶子.png", CreateTime = DateTime.Now },
                new Noodle { Name = "薄宽", Price = 11, Introduce = "比韭叶宽一点，比大宽窄一点", ImgUrl = "/images/薄宽.png", CreateTime = DateTime.Now },
                new Noodle { Name = "大宽", Price = 10, Introduce = "比嘴还宽了", ImgUrl = "/images/大宽.png", CreateTime = DateTime.Now },
                new Noodle { Name = "荞麦棱子", Price = 15, Introduce = "好像知道师傅怎么拉出来的", ImgUrl = "/images/荞麦棱子.png", CreateTime = DateTime.Now },
                new Noodle { Name = "一窝丝", Price = 15, Introduce = "我也没吃过", ImgUrl = "/images/一窝丝.png", CreateTime = DateTime.Now }
            );
            context.SaveChanges();
        }
    }
}
