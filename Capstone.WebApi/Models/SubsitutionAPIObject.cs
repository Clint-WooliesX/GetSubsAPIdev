namespace Capstone.WebApi.Models
{
    public class SubsitutionAPIObject
    {
        public class Rootobject
        {
            public string openapi { get; set; }
            public Info info { get; set; }
            public Server[] servers { get; set; }
            public Paths paths { get; set; }
            public Components components { get; set; }
            public Security[] security { get; set; }
        }

        public class Info
        {
            public string title { get; set; }
            public string description { get; set; }
            public string version { get; set; }
        }

        public class Paths
        {
            public StoresFulfilmentstorekeyRecommendationStockcode storesfulfilmentStoreKeyrecommendationstockCode { get; set; }
            public StoresFulfilmentstorekeyRecommendation storesfulfilmentStoreKeyrecommendation { get; set; }
            public SubstitutionOrdersOrderid substitutionordersOrderId { get; set; }
            public SubstitutionOrdersOrderid1 substitutionordersorderId { get; set; }
            public TwowaycommsSmsSearch twowaycommssmssearch { get; set; }
            public Version version { get; set; }
        }

        public class StoresFulfilmentstorekeyRecommendationStockcode
        {
            public Get get { get; set; }
        }

        public class Get
        {
            public string[] tags { get; set; }
            public string summary { get; set; }
            public Parameter[] parameters { get; set; }
            public Responses responses { get; set; }
        }

        public class Responses
        {
            public _200 _200 { get; set; }
            public _400 _400 { get; set; }
            public _404 _404 { get; set; }
        }

        public class _200
        {
            public string description { get; set; }
            public Content content { get; set; }
        }

        public class Content
        {
            public TextPlain textplain { get; set; }
            public ApplicationJson applicationjson { get; set; }
            public TextJson textjson { get; set; }
        }

        public class TextPlain
        {
            public Schema schema { get; set; }
        }

        public class Schema
        {
            public string type { get; set; }
            public Items items { get; set; }
        }

        public class Items
        {
            public string _ref { get; set; }
        }

        public class ApplicationJson
        {
            public Schema1 schema { get; set; }
        }

        public class Schema1
        {
            public string type { get; set; }
            public Items1 items { get; set; }
        }

        public class Items1
        {
            public string _ref { get; set; }
        }

        public class TextJson
        {
            public Schema2 schema { get; set; }
        }

        public class Schema2
        {
            public string type { get; set; }
            public Items2 items { get; set; }
        }

        public class Items2
        {
            public string _ref { get; set; }
        }

        public class _400
        {
            public string description { get; set; }
            public Content1 content { get; set; }
        }

        public class Content1
        {
            public TextPlain1 textplain { get; set; }
            public ApplicationJson1 applicationjson { get; set; }
            public TextJson1 textjson { get; set; }
        }

        public class TextPlain1
        {
            public Schema3 schema { get; set; }
        }

        public class Schema3
        {
            public string _ref { get; set; }
        }

        public class ApplicationJson1
        {
            public Schema4 schema { get; set; }
        }

        public class Schema4
        {
            public string _ref { get; set; }
        }

        public class TextJson1
        {
            public Schema5 schema { get; set; }
        }

        public class Schema5
        {
            public string _ref { get; set; }
        }

        public class _404
        {
            public string description { get; set; }
            public Content2 content { get; set; }
        }

        public class Content2
        {
            public TextPlain2 textplain { get; set; }
            public ApplicationJson2 applicationjson { get; set; }
            public TextJson2 textjson { get; set; }
        }

        public class TextPlain2
        {
            public Schema6 schema { get; set; }
        }

        public class Schema6
        {
            public string _ref { get; set; }
        }

        public class ApplicationJson2
        {
            public Schema7 schema { get; set; }
        }

        public class Schema7
        {
            public string _ref { get; set; }
        }

        public class TextJson2
        {
            public Schema8 schema { get; set; }
        }

        public class Schema8
        {
            public string _ref { get; set; }
        }

        public class Parameter
        {
            public string name { get; set; }
            public string _in { get; set; }
            public string description { get; set; }
            public bool required { get; set; }
            public Schema9 schema { get; set; }
        }

        public class Schema9
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class StoresFulfilmentstorekeyRecommendation
        {
            public Get1 get { get; set; }
        }

        public class Get1
        {
            public string[] tags { get; set; }
            public string summary { get; set; }
            public Parameter1[] parameters { get; set; }
            public Responses1 responses { get; set; }
        }

        public class Responses1
        {
            public _2001 _200 { get; set; }
            public _4001 _400 { get; set; }
            public _4041 _404 { get; set; }
        }

        public class _2001
        {
            public string description { get; set; }
            public Content3 content { get; set; }
        }

        public class Content3
        {
            public TextPlain3 textplain { get; set; }
            public ApplicationJson3 applicationjson { get; set; }
            public TextJson3 textjson { get; set; }
        }

        public class TextPlain3
        {
            public Schema10 schema { get; set; }
        }

        public class Schema10
        {
            public string type { get; set; }
            public Items3 items { get; set; }
        }

        public class Items3
        {
            public string _ref { get; set; }
        }

        public class ApplicationJson3
        {
            public Schema11 schema { get; set; }
        }

        public class Schema11
        {
            public string type { get; set; }
            public Items4 items { get; set; }
        }

        public class Items4
        {
            public string _ref { get; set; }
        }

        public class TextJson3
        {
            public Schema12 schema { get; set; }
        }

        public class Schema12
        {
            public string type { get; set; }
            public Items5 items { get; set; }
        }

        public class Items5
        {
            public string _ref { get; set; }
        }

        public class _4001
        {
            public string description { get; set; }
            public Content4 content { get; set; }
        }

        public class Content4
        {
            public TextPlain4 textplain { get; set; }
            public ApplicationJson4 applicationjson { get; set; }
            public TextJson4 textjson { get; set; }
        }

        public class TextPlain4
        {
            public Schema13 schema { get; set; }
        }

        public class Schema13
        {
            public string _ref { get; set; }
        }

        public class ApplicationJson4
        {
            public Schema14 schema { get; set; }
        }

        public class Schema14
        {
            public string _ref { get; set; }
        }

        public class TextJson4
        {
            public Schema15 schema { get; set; }
        }

        public class Schema15
        {
            public string _ref { get; set; }
        }

        public class _4041
        {
            public string description { get; set; }
            public Content5 content { get; set; }
        }

        public class Content5
        {
            public TextPlain5 textplain { get; set; }
            public ApplicationJson5 applicationjson { get; set; }
            public TextJson5 textjson { get; set; }
        }

        public class TextPlain5
        {
            public Schema16 schema { get; set; }
        }

        public class Schema16
        {
            public string _ref { get; set; }
        }

        public class ApplicationJson5
        {
            public Schema17 schema { get; set; }
        }

        public class Schema17
        {
            public string _ref { get; set; }
        }

        public class TextJson5
        {
            public Schema18 schema { get; set; }
        }

        public class Schema18
        {
            public string _ref { get; set; }
        }

        public class Parameter1
        {
            public string name { get; set; }
            public string _in { get; set; }
            public string description { get; set; }
            public bool required { get; set; }
            public Schema19 schema { get; set; }
        }

        public class Schema19
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class SubstitutionOrdersOrderid
        {
            public Get2 get { get; set; }
        }

        public class Get2
        {
            public string[] tags { get; set; }
            public Parameter2[] parameters { get; set; }
            public Responses2 responses { get; set; }
        }

        public class Responses2
        {
            public _2002 _200 { get; set; }
        }

        public class _2002
        {
            public string description { get; set; }
        }

        public class Parameter2
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public Schema20 schema { get; set; }
        }

        public class Schema20
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class SubstitutionOrdersOrderid1
        {
            public Patch patch { get; set; }
        }

        public class Patch
        {
            public string[] tags { get; set; }
            public Parameter3[] parameters { get; set; }
            public Requestbody requestBody { get; set; }
            public Responses3 responses { get; set; }
        }

        public class Requestbody
        {
            public Content6 content { get; set; }
        }

        public class Content6
        {
            public ApplicationJsonPatchJson applicationjsonpatchjson { get; set; }
            public ApplicationJson6 applicationjson { get; set; }
            public TextJson6 textjson { get; set; }
            //  public ApplicationJson applicationjson { get; set; }
        }

        public class ApplicationJsonPatchJson
        {
            public Schema21 schema { get; set; }
        }

        public class Schema21
        {
            public string type { get; set; }
            public Items6 items { get; set; }
        }

        public class Items6
        {
            public string _ref { get; set; }
        }

        public class ApplicationJson6
        {
            public Schema22 schema { get; set; }
        }

        public class Schema22
        {
            public string type { get; set; }
            public Items7 items { get; set; }
        }

        public class Items7
        {
            public string _ref { get; set; }
        }

        public class TextJson6
        {
            public Schema23 schema { get; set; }
        }

        public class Schema23
        {
            public string type { get; set; }
            public Items8 items { get; set; }
        }

        public class Items8
        {
            public string _ref { get; set; }
        }

        // public class ApplicationJson
        // {
        //   public Schema24 schema { get; set; }
        //   }

        public class Schema24
        {
            public string type { get; set; }
            public Items9 items { get; set; }
        }

        public class Items9
        {
            public string _ref { get; set; }
        }

        public class Responses3
        {
            public _2003 _200 { get; set; }
        }

        public class _2003
        {
            public string description { get; set; }
        }

        public class Parameter3
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public Schema25 schema { get; set; }
        }

        public class Schema25
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class TwowaycommsSmsSearch
        {
            public Get3 get { get; set; }
        }

        public class Get3
        {
            public string[] tags { get; set; }
            public Parameter4[] parameters { get; set; }
            public Responses4 responses { get; set; }
        }

        public class Responses4
        {
            public _2004 _200 { get; set; }
            public _4002 _400 { get; set; }
        }

        public class _2004
        {
            public string description { get; set; }
            public Content7 content { get; set; }
        }

        public class Content7
        {
            public TextPlain6 textplain { get; set; }
            public ApplicationJson7 applicationjson { get; set; }
            public TextJson7 textjson { get; set; }
        }

        public class TextPlain6
        {
            public Schema26 schema { get; set; }
        }

        public class Schema26
        {
            public string type { get; set; }
            public Items10 items { get; set; }
        }

        public class Items10
        {
            public string _ref { get; set; }
        }

        public class ApplicationJson7
        {
            public Schema27 schema { get; set; }
        }

        public class Schema27
        {
            public string type { get; set; }
            public Items11 items { get; set; }
        }

        public class Items11
        {
            public string _ref { get; set; }
        }

        public class TextJson7
        {
            public Schema28 schema { get; set; }
        }

        public class Schema28
        {
            public string type { get; set; }
            public Items12 items { get; set; }
        }

        public class Items12
        {
            public string _ref { get; set; }
        }

        public class _4002
        {
            public string description { get; set; }
            public Content8 content { get; set; }
        }

        public class Content8
        {
            public TextPlain7 textplain { get; set; }
            public ApplicationJson8 applicationjson { get; set; }
            public TextJson8 textjson { get; set; }
        }

        public class TextPlain7
        {
            public Schema29 schema { get; set; }
        }

        public class Schema29
        {
            public string _ref { get; set; }
        }

        public class ApplicationJson8
        {
            public Schema30 schema { get; set; }
        }

        public class Schema30
        {
            public string _ref { get; set; }
        }

        public class TextJson8
        {
            public Schema31 schema { get; set; }
        }

        public class Schema31
        {
            public string _ref { get; set; }
        }

        public class Parameter4
        {
            public string name { get; set; }
            public string _in { get; set; }
            public Schema32 schema { get; set; }
        }

        public class Schema32
        {
            public string type { get; set; }
        }

        public class Version
        {
            public Get4 get { get; set; }
        }

        public class Get4
        {
            public string[] tags { get; set; }
            public Responses5 responses { get; set; }
        }

        public class Responses5
        {
            public _2005 _200 { get; set; }
        }

        public class _2005
        {
            public string description { get; set; }
            public Content9 content { get; set; }
        }

        public class Content9
        {
            public ApplicationJson9 applicationjson { get; set; }
        }

        public class ApplicationJson9
        {
            public Schema33 schema { get; set; }
        }

        public class Schema33
        {
            public string type { get; set; }
        }

        public class Components
        {
            public Schemas schemas { get; set; }
            public Securityschemes securitySchemes { get; set; }
        }

        public class Schemas
        {
            public Article Article { get; set; }
            public Customerfeedback CustomerFeedback { get; set; }
            public Customerreply CustomerReply { get; set; }
            public Problemdetails ProblemDetails { get; set; }
            public Productrecommendation ProductRecommendation { get; set; }
            public Recommendation Recommendation { get; set; }
            public Shoppersmsdetail ShopperSmsDetail { get; set; }
            public Smsreplystatus1 SmsReplyStatus { get; set; }
            public Updatesubstitutionsrequest UpdateSubstitutionsRequest { get; set; }
        }

        public class Article
        {
            public string type { get; set; }
            public Properties properties { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Properties
        {
            public Linenumber lineNumber { get; set; }
            public Stockcode stockCode { get; set; }
            public Name name { get; set; }
            public Orderedquantity orderedQuantity { get; set; }
            public Totalsuppliedquantity totalSuppliedQuantity { get; set; }
            public Pricingunit pricingUnit { get; set; }
            public Cassvolumesize cassVolumeSize { get; set; }
            public Useweightrange useWeightRange { get; set; }
            public Minweight minWeight { get; set; }
            public Maxweight maxWeight { get; set; }
            public Eachmultiplier eachMultiplier { get; set; }
        }

        public class Linenumber
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Stockcode
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Name
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Orderedquantity
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Totalsuppliedquantity
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Pricingunit
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Cassvolumesize
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Useweightrange
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Minweight
        {
            public string type { get; set; }
            public string format { get; set; }
            public bool nullable { get; set; }
        }

        public class Maxweight
        {
            public string type { get; set; }
            public string format { get; set; }
            public bool nullable { get; set; }
        }

        public class Eachmultiplier
        {
            public string type { get; set; }
            public string format { get; set; }
            public bool nullable { get; set; }
        }

        public class Customerfeedback
        {
            public string[] _enum { get; set; }
            public string type { get; set; }
        }

        public class Customerreply
        {
            public string type { get; set; }
            public Properties1 properties { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Properties1
        {
            public Reply reply { get; set; }
            public Smsreplystatus smsReplyStatus { get; set; }
            public Correlationid correlationId { get; set; }
            public Createdatetimeoffset createDateTimeOffset { get; set; }
            public Smsreplytimeinutc smsReplyTimeInUtc { get; set; }
        }

        public class Reply
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Smsreplystatus
        {
            public string _ref { get; set; }
        }

        public class Correlationid
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Createdatetimeoffset
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Smsreplytimeinutc
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Problemdetails
        {
            public string type { get; set; }
            public Properties2 properties { get; set; }
            public Additionalproperties additionalProperties { get; set; }
        }

        public class Properties2
        {
            public Type type { get; set; }
            public Title title { get; set; }
            public Status status { get; set; }
            public Detail detail { get; set; }
            public Instance instance { get; set; }
        }

        public class Type
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Title
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Status
        {
            public string type { get; set; }
            public string format { get; set; }
            public bool nullable { get; set; }
        }

        public class Detail
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Instance
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Additionalproperties
        {
        }

        public class Productrecommendation
        {
            public string type { get; set; }
            public Properties3 properties { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Properties3
        {
            public Active active { get; set; }
            public Stockcode1 stockCode { get; set; }
            public Recommendations recommendations { get; set; }
        }

        public class Active
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Stockcode1
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Recommendations
        {
            public string type { get; set; }
            public Items13 items { get; set; }
            public bool nullable { get; set; }
        }

        public class Items13
        {
            public string _ref { get; set; }
        }

        public class Recommendation
        {
            public string type { get; set; }
            public Properties4 properties { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Properties4
        {
            public Stockcode2 stockCode { get; set; }
            public Score score { get; set; }
            public Quantity quantity { get; set; }
        }

        public class Stockcode2
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Score
        {
            public string type { get; set; }
            public string format { get; set; }
            public bool nullable { get; set; }
        }

        public class Quantity
        {
            public string type { get; set; }
            public string format { get; set; }
            public bool nullable { get; set; }
        }

        public class Shoppersmsdetail
        {
            public string type { get; set; }
            public Properties5 properties { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Properties5
        {
            public Correlationid1 correlationId { get; set; }
            public Orderid orderId { get; set; }
            public Cutoffdatetimeutc cutoffDateTimeUtc { get; set; }
            public Dispatchcutoffdatetimeutc dispatchCutoffDateTimeUtc { get; set; }
            public Storeid storeId { get; set; }
            public Storewintimezoneid storeWinTimeZoneId { get; set; }
            public Shopperid shopperId { get; set; }
            public Sessionname sessionName { get; set; }
            public Pickingzone pickingZone { get; set; }
            public Orderedarticle orderedArticle { get; set; }
            public Fulfilmentstorekey fulfilmentStoreKey { get; set; }
            public Substitutedarticles substitutedArticles { get; set; }
            public Replies replies { get; set; }
            public Invalidsmscount invalidSmsCount { get; set; }
            public Latesmscount lateSmsCount { get; set; }
            public Createdonutc createdOnUtc { get; set; }
        }

        public class Correlationid1
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Orderid
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Cutoffdatetimeutc
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Dispatchcutoffdatetimeutc
        {
            public string type { get; set; }
            public string format { get; set; }
            public bool nullable { get; set; }
        }

        public class Storeid
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Storewintimezoneid
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Shopperid
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Sessionname
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Pickingzone
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Orderedarticle
        {
            public string _ref { get; set; }
        }

        public class Fulfilmentstorekey
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Substitutedarticles
        {
            public string type { get; set; }
            public Items14 items { get; set; }
            public bool nullable { get; set; }
            public bool readOnly { get; set; }
        }

        public class Items14
        {
            public string _ref { get; set; }
        }

        public class Replies
        {
            public string type { get; set; }
            public Items15 items { get; set; }
            public bool nullable { get; set; }
            public bool readOnly { get; set; }
        }

        public class Items15
        {
            public string _ref { get; set; }
        }

        public class Invalidsmscount
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Latesmscount
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Createdonutc
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Smsreplystatus1
        {
            public string[] _enum { get; set; }
            public string type { get; set; }
        }

        public class Updatesubstitutionsrequest
        {
            public string type { get; set; }
            public Properties6 properties { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Properties6
        {
            public Id id { get; set; }
            public Originalstockcode originalStockCode { get; set; }
            public Customerfeedback1 customerFeedback { get; set; }
        }

        public class Id
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Originalstockcode
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Customerfeedback1
        {
            public string _ref { get; set; }
        }

        public class Securityschemes
        {
            public Apikey ApiKey { get; set; }
            public Bearer Bearer { get; set; }
        }

        public class Apikey
        {
            public string type { get; set; }
            public string description { get; set; }
            public string name { get; set; }
            public string _in { get; set; }
        }

        public class Bearer
        {
            public string type { get; set; }
            public string description { get; set; }
            public string scheme { get; set; }
        }

        public class Server
        {
            public string url { get; set; }
        }

        public class Security
        {
            public object[] ApiKey { get; set; }
            public object[] Bearer { get; set; }
        }
    }
}
