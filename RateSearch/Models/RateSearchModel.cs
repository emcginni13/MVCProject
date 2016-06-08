using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateSearch.Models
{
    public class RateSearchModel
    {
            public Data data { get; set; }

        public class Data
        {
            public string id { get; set; }
            public Rate_Search rate_search { get; set; }
            public Rate_Results rate_results { get; set; }
        }

        public class Rate_Search
        {
            public int loan_purpose_type_id { get; set; }
            public float amount { get; set; }
            public float down_payment_percent { get; set; }
            public bool is_military { get; set; }
            public bool is_first_home_purchase { get; set; }
            public int credit_score_type_id { get; set; }
            public int actual_credit_score { get; set; }
            public object household_annual_income { get; set; }
            public object existing_loan_balance { get; set; }
            public object loan_type_id { get; set; }
            public object existing_loan_cashout_amount { get; set; }
            public int occupancy_type_id { get; set; }
            public int occupancy_length_type_id { get; set; }
            public int property_type_id { get; set; }
            public int property_state_id { get; set; }
            public int property_county_id { get; set; }
            public string property_zip_code { get; set; }
            public float property_estimated_value { get; set; }
            public float ltv { get; set; }
            public object source { get; set; }
            public object campaign { get; set; }
            public object lead_id { get; set; }
            public object lead { get; set; }
            public bool filter { get; set; }
            public bool uhm_rates { get; set; }
            public object requester_user_id { get; set; }
        }

        public class Rate_Results
        {
            public DateTime created_at { get; set; }
            public bool no_qualified_products { get; set; }
            public object disqualification_message { get; set; }
            public int selected_product_id { get; set; }
            public int selected_rate_id { get; set; }
            public object category_1_description { get; set; }
            public object category_2_description { get; set; }
            public object category_3_description { get; set; }
            public Product[] products { get; set; }
            public string major_type { get; set; }
            public string minor_type { get; set; }
        }

        public class Product
        {
            public string name { get; set; }
            public int loan_type_id { get; set; }
            public int amortization_type_id { get; set; }
            public int amortization_term_months { get; set; }
            public int initial_period_years { get; set; }
            public int loan_term_type_id { get; set; }
            public int id { get; set; }
            public Rate[] rates { get; set; }
            public float monthly_mortgage_insurance { get; set; }
            public float monthly_property_tax { get; set; }
            public float monthly_homeowners_insurance { get; set; }
            public int category_1_subtotal { get; set; }
            public float category_2_subtotal { get; set; }
            public float category_3_subtotal { get; set; }
            public Closing_Costs1[] closing_costs { get; set; }
            public Title_Fees title_fees { get; set; }
            public float original_amount { get; set; }
            public float amount { get; set; }
            public float upfront_guarantee_factor { get; set; }
            public float upfront_guarantee_fee { get; set; }
            public float mip_factor { get; set; }
            public float absolute_cap { get; set; }
            public float first_cap { get; set; }
            public float periodic_cap { get; set; }
            public float relative_cap { get; set; }
        }

        public class Title_Fees
        {
            public float settlement_charge { get; set; }
            public float premium_tax { get; set; }
            public float cpl_fee { get; set; }
            public float title_services_total { get; set; }
            public float owners_title_ins { get; set; }
            public float total_govt_record_charge { get; set; }
            public float total_transfer_tax { get; set; }
        }

        public class Rate
        {
            public float rate { get; set; }
            public float price { get; set; }
            public float apr { get; set; }
            public float total_monthly_payment { get; set; }
            public float original_monthly_payment_pi { get; set; }
            public float monthly_payment_pi { get; set; }
            public float due_at_signing { get; set; }
            public float down_payment { get; set; }
            public float total_closing_costs { get; set; }
            public float total_closing_cost { get; set; }
            public float total_escrow { get; set; }
            public float points { get; set; }
            public float points_as_dollars { get; set; }
            public Closing_Costs[] closing_costs { get; set; }
            public Escrow_Costs[] escrow_costs { get; set; }
            public int id { get; set; }
            public float financed_closing_costs_by_rate { get; set; }
            public float fully_indexed_rate { get; set; }
            public float fully_indexed_monthly_payment_pi { get; set; }
            public float monthly_mip { get; set; }
        }

        public class Closing_Costs
        {
            public string description { get; set; }
            public float cost { get; set; }
            public bool super_script { get; set; }
            public int category { get; set; }
            public int sort_order { get; set; }
        }

        public class Escrow_Costs
        {
            public string description { get; set; }
            public float cost { get; set; }
            public bool super_script { get; set; }
            public int category { get; set; }
            public int sort_order { get; set; }
        }

        public class Closing_Costs1
        {
            public string description { get; set; }
            public float cost { get; set; }
            public bool super_script { get; set; }
            public int category { get; set; }
            public int sort_order { get; set; }
        }

    }
}
